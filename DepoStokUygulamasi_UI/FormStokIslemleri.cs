using BusinessLayer.Concrete;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DepoStokUygulamasi_UI
{
    public partial class FormStokIslemleri : Form
    {
        public FormStokIslemleri()
        {
            InitializeComponent();
        }

        StockOperationManager manager = new StockOperationManager();

        DataTable dataTable = new DataTable();

        private void FormStokIslemleri_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'depoStokUygulamasiDataSet4.Products' table. You can move, or remove it, as needed.
            this.productsTableAdapter.Fill(this.depoStokUygulamasiDataSet4.Products);
            // TODO: This line of code loads data into the 'depoStokUygulamasiDataSet3.Companies' table. You can move, or remove it, as needed.
            this.companiesTableAdapter.Fill(this.depoStokUygulamasiDataSet3.Companies);

            dataTable.Columns.Add("Ürün Id", typeof(string));
            dataTable.Columns.Add("Fiyat", typeof(string));
            dataTable.Columns.Add("Adet", typeof(string));

        }

        private void btnYeniKayıt_Click(object sender, EventArgs e)
        {
            FormuTemizle();
        }

        private void FormuTemizle()
        {
            tbxStokIslemId.Clear();
            cbxFirmaAdi.Text = "";
            cbxIslemTuru.Text = "";            
            dtpIslemTarihi.Text = DateTime.Now.ToString();
        }

        private void btnUrunEkle_Click(object sender, EventArgs e)
        {
            if (cbxUrunAdi.Text != "" && tbxFiyat.Text != "" && tbxAdet.Text != "")
            {
                dataTable.Rows.Add(cbxUrunAdi.SelectedValue.ToString(), tbxFiyat.Text, tbxAdet.Text);

                dataGridView1.DataSource = dataTable;

                tbxAdet.Clear();
                tbxFiyat.Clear();
                cbxUrunAdi.Text = "";
            }
            else
            {
                MessageBox.Show("Lütfen önce ürün seçin, Fiyat ve Adet girin.");
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            ICollection<StockOperationDetails> details = new List<StockOperationDetails>();

            for (int i = 0; i < (dataGridView1.Rows.Count); i++)
            {
                StockOperationDetails operationDetails = new StockOperationDetails();

                operationDetails.ProductId = Convert.ToInt32(dataGridView1.Rows[i].Cells[0].Value);
                operationDetails.Fiyat = Convert.ToDouble(dataGridView1.Rows[i].Cells[1].Value);
                operationDetails.Adet = Convert.ToInt32(dataGridView1.Rows[i].Cells[2].Value);

                details.Add(operationDetails);
            }

            StockOperation stockOperation = new StockOperation();

            stockOperation.CompanyId = Convert.ToInt32(cbxFirmaAdi.SelectedValue);
            stockOperation.IslemTuru = cbxIslemTuru.Text;
            stockOperation.IslemTarihi = dtpIslemTarihi.Value;
            stockOperation.StockOperationDetails = details;

            string mesaj = manager.StockOperationAddBL(stockOperation);

            MessageBox.Show(mesaj);
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            if (rbtnTumKayitlar.Checked)
            {
                // Tüm kayıtlar listelenecek

                dataGridView2.DataSource = manager.GetAllBL();
            }
            else if (rbtnGirisIslemleri.Checked)
            {
                // Sadece giriş işlemleri listelenecek.

                //dataGridView2.DataSource = manager.GetAllBL().Where(x => x.IslemTuru == "Giriş İşlemi").ToList();

                // aşağıdaki yöntem daha verimli

                dataGridView2.DataSource = manager.GetAllBL("Giriş İşlemi");
            }
            else if (rbtnCikisIslemleri.Checked)
            {
                // Sadece çıkış işlemleri listelenecek.

                //dataGridView2.DataSource = manager.GetAllBL().Where(x => x.IslemTuru == "Çıkış İşlemi").ToList();

                // yukarıdaki sorgulama önce veritabanından tüm kayıtları getirir. Daha sonra biz List olarak gelen veri içinde sorgulama yaparak Çkış işlemlerinin listelenmesini sağlıyoruz.
                // Burada GenericRepository'deki public List<T> List(Expression<Func<T, bool>> filter) metodu kullanırsak, Tüm kayıtları değil sadece istenen kayıtları veritabanından sorgulayacaktır. 2. yöntem performans açısından daha kullanışlıdır.

                dataGridView2.DataSource = manager.GetAllBL("Çıkış İşlemi");
            }
            else
            {
                MessageBox.Show("İşlem seçimi yapmadınız.");
            }
        }

        private void dataGridView2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            tbxStokIslemId.Text = dataGridView2.CurrentRow.Cells[0].Value.ToString();
            cbxFirmaAdi.Text = dataGridView2.CurrentRow.Cells[1].Value.ToString();
            cbxIslemTuru.Text = dataGridView2.CurrentRow.Cells[3].Value.ToString();
            dtpIslemTarihi.Text = dataGridView2.CurrentRow.Cells[2].Value.ToString();

            ShowStockOperationDetails();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (tbxStokIslemId.Text != "")
            {
                manager.StockOperationDeleteBL(Convert.ToInt32(tbxStokIslemId.Text));
            }
            else
            {
                MessageBox.Show("Silmek istediğiniz kaydı seçin.");
            }
            
        }

        private void ShowStockOperationDetails()
        {
            StockOperationDetailManager detailManager = new StockOperationDetailManager();

            int id = Convert.ToInt32(dataGridView2.CurrentRow.Cells[0].Value);

            dataGridView1.DataSource = detailManager.ListDetails(id);
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {

        }
    }
}
