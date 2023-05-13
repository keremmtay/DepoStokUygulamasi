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
    public partial class FormProducts : Form
    {
        public FormProducts()
        {
            InitializeComponent();
        }

        ProductManager manager = new ProductManager();

        private void FormProducts_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'depoStokUygulamasiDataSet2.Categories' table. You can move, or remove it, as needed.
            this.categoriesTableAdapter.Fill(this.depoStokUygulamasiDataSet2.Categories);
            // TODO: This line of code loads data into the 'depoStokUygulamasiDataSet1.Warehouses' table. You can move, or remove it, as needed.
            this.warehousesTableAdapter.Fill(this.depoStokUygulamasiDataSet1.Warehouses);
            // TODO: This line of code loads data into the 'depoStokUygulamasiDataSet.Units' table. You can move, or remove it, as needed.
            this.unitsTableAdapter.Fill(this.depoStokUygulamasiDataSet.Units);
            Listele();
        }

        private void Listele()
        {
            dataGridView1.DataSource = manager.GetAllBL();
        }

        private void btnProductKaydet_Click(object sender, EventArgs e)
        {
            Product product = new Product();
            product.UrunAdi = tbxUrunAdi.Text;
            product.CategoryId = Convert.ToInt32(cbxKategoriId.SelectedValue);
            product.BarkodKodu = tbxBarkodKodu.Text;
            product.StokMiktari = Convert.ToInt32(tbxStokMiktarı.Text);
            product.BirimFiyat = Convert.ToDouble(tbxBirimFiyat.Text);
            product.UnitId = Convert.ToInt32(cbxUnitId.SelectedValue);
            product.RafNo = tbxRafNo.Text;
            product.WarehouseId = Convert.ToInt32(cbxDepoId.SelectedValue);
            product.MinStok = Convert.ToInt32(tbxMinStok.Text);
            product.MaxStok = Convert.ToInt32(tbxMaxStok.Text);

            string mesaj = manager.ProductAddBL(product);

            MessageBox.Show(mesaj);

            Listele();

            FormuTemizle();
        }

        private void FormuTemizle()
        {
            foreach (Control item in this.Controls)
            {
                if (item.GetType().ToString() == "System.Windows.Forms.TextBox")
                {
                    item.Text = "";
                }
                if (item.GetType().ToString() == "System.Windows.Forms.ComboBox")
                {
                    item.Text = "";
                }
            }
        }

        private void btnFormuTemizle_Click(object sender, EventArgs e)
        {
            FormuTemizle();
        }

        private void btnProductGuncelle_Click(object sender, EventArgs e)
        {
            if (tbxUrunId.Text != "")
            {
                Product product = new Product();
                product.Id = Convert.ToInt32(tbxUrunId.Text);
                product.UrunAdi = tbxUrunAdi.Text;
                product.CategoryId = Convert.ToInt32(cbxKategoriId.SelectedValue);
                product.BarkodKodu = tbxBarkodKodu.Text;
                product.StokMiktari = Convert.ToInt32(tbxStokMiktarı.Text);
                product.BirimFiyat = Convert.ToDouble(tbxBirimFiyat.Text);
                product.UnitId = Convert.ToInt32(cbxUnitId.SelectedValue);
                product.RafNo = tbxRafNo.Text;
                product.WarehouseId = Convert.ToInt32(cbxDepoId.SelectedValue);
                product.MinStok = Convert.ToInt32(tbxMinStok.Text);
                product.MaxStok = Convert.ToInt32(tbxMaxStok.Text);

                string mesaj = manager.ProductUpdateBL(product);

                MessageBox.Show(mesaj);

                Listele();

                FormuTemizle();
            }
            else
            {
                MessageBox.Show("Lütfen güncellemek istediğiniz kaydı seçin.");
            }
        }

        private void btnProductSil_Click(object sender, EventArgs e)
        {
            if (tbxUrunId.Text != "")
            {
                manager.ProductDeleteBL(Convert.ToInt32(tbxUrunId.Text));

                MessageBox.Show("Ürün kaydı silindi.");

                Listele();

                FormuTemizle();
            }
            else
            {
                MessageBox.Show("Lütfen silmek istediğiniz kaydı seçin.");
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            tbxUrunId.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            tbxUrunAdi.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            cbxKategoriId.SelectedValue = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            tbxBarkodKodu.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            tbxStokMiktarı.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            tbxBirimFiyat.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            cbxUnitId.SelectedValue = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            tbxRafNo.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            cbxDepoId.SelectedValue = dataGridView1.CurrentRow.Cells[8].Value.ToString();
            tbxMinStok.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();
            tbxMaxStok.Text = dataGridView1.CurrentRow.Cells[10].Value.ToString();
        }

        private void btnKategoriEkle_Click(object sender, EventArgs e)
        {
            FormKategori formKategori = new FormKategori();

            formKategori.ShowDialog();
        }

        private void btnBirimEkle_Click(object sender, EventArgs e)
        {
            FormUnit formUnit = new FormUnit();

            formUnit.ShowDialog();
        }

        private void btnDepoEkle_Click(object sender, EventArgs e)
        {
            FormWarehouse formWarehouse = new FormWarehouse();

            formWarehouse.ShowDialog();
        }

        private void cbxKategoriId_Click(object sender, EventArgs e)
        {
            this.categoriesTableAdapter.Fill(this.depoStokUygulamasiDataSet2.Categories);
        }

        private void cbxUnitId_Click(object sender, EventArgs e)
        {
            this.unitsTableAdapter.Fill(this.depoStokUygulamasiDataSet.Units);
        }

        private void cbxDepoId_Click(object sender, EventArgs e)
        {
            this.warehousesTableAdapter.Fill(this.depoStokUygulamasiDataSet1.Warehouses);
        }

        private void tbxUrunAra_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = manager.SearchByProductName(tbxUrunAra.Text);
        }
    }
}
