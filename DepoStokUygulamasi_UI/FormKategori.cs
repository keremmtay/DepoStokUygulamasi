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
    public partial class FormKategori : Form
    {
        public FormKategori()
        {
            InitializeComponent();
        }

        CategoryManager manager = new CategoryManager();

        private void btnKategoriListele_Click(object sender, EventArgs e)
        {
            Listele();
        }

        private void Listele()
        {
            dataGridView1.DataSource = manager.GetAllBL();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            Category category = new Category();
            category.KategoriAdi = tbxKategoriAdi.Text;
            category.Aciklama = tbxKategoriAciklama.Text;

            string mesaj = manager.CategoryAddBL(category);

            MessageBox.Show(mesaj);

            FormuTemizle();

            Listele();
        }

        private void btnFormuTemizle_Click(object sender, EventArgs e)
        {
            FormuTemizle();
        }

        private void FormuTemizle()
        {
            tbxKategoriId.Clear();
            tbxKategoriAdi.Clear();
            tbxKategoriAciklama.Clear();
        }

        private void FormKategori_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            tbxKategoriId.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            tbxKategoriAdi.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            if (dataGridView1.CurrentRow.Cells[2].Value != null)
            {
                tbxKategoriAciklama.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            }
            
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            // Category nesnesi oluşturacağız.. Textboxlardan aldığımız veriyi bu nesne içerisine aktaracağız.

            if (tbxKategoriId.Text != "")
            {
                Category category = new Category();
                category.Id = Convert.ToInt32(tbxKategoriId.Text);
                category.KategoriAdi = tbxKategoriAdi.Text;
                category.Aciklama = tbxKategoriAciklama.Text;
                
                string mesaj = manager.CategoryUpdateBL(category);

                MessageBox.Show(mesaj);

                Listele();

                FormuTemizle();
            }
            else
            {
                MessageBox.Show("Lütfen güncellemek istediğiniz kaydı seçin.");
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (tbxKategoriId.Text != string.Empty)
            {
                manager.CategoryDeleteBL(Convert.ToInt32(tbxKategoriId.Text));

                MessageBox.Show("Kategori silindi.");

                Listele();

                FormuTemizle();
            }
            else
            {
                MessageBox.Show("Lütfen silmek istediğiniz kaydı seçin.");
            }
        }
    }
}
