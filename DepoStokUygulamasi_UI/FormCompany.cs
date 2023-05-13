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
    public partial class FormCompany : Form
    {
        public FormCompany()
        {
            InitializeComponent();
        }

        CompanyManager manager = new CompanyManager();

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            tbxFirmaId.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            tbxFirmaAdi.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            tbxFirmaTuru.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            tbxAdres.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            tbxTelefon.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            tbxEmail.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            tbxYetkiliKisi.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            tbxAciklama.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            tbxVergiNo.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
            tbxHesapNo.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();            
        }

        private void Listele()
        {
            dataGridView1.DataSource = manager.GetAllBL();
        }

        private void FormCompany_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void FormuTemizle()
        {
            tbxFirmaId.Clear();
            tbxFirmaAdi.Clear();
            tbxFirmaTuru.Clear();
            tbxAdres.Clear();
            tbxTelefon.Clear();
            tbxEmail.Clear();
            tbxYetkiliKisi.Clear();
            tbxAciklama.Clear();
            tbxVergiNo.Clear();
            tbxHesapNo.Clear();
        }

        

        private void btnFormuTemizle_Click(object sender, EventArgs e)
        {
            FormuTemizle();
        }

        private void btnCompanyKaydet_Click(object sender, EventArgs e)
        {
            Company company = new Company();
            company.FirmaAdi = tbxFirmaAdi.Text;
            company.FirmaTuru = tbxFirmaTuru.Text;
            company.Adres = tbxAdres.Text;
            company.Telefon = tbxTelefon.Text;
            company.Email = tbxEmail.Text;
            company.YetkiliKisi = tbxYetkiliKisi.Text;
            company.Aciklama = tbxAciklama.Text;
            company.VergiNo = tbxVergiNo.Text;
            company.HesapNo = tbxHesapNo.Text;

            string mesaj = manager.CompanyAddBL(company);

            MessageBox.Show(mesaj);

            Listele();

            FormuTemizle();
        }

        private void btnCompanyGuncelle_Click(object sender, EventArgs e)
        {
            if (tbxFirmaId.Text != "")
            {
                Company company = new Company();
                company.Id = Convert.ToInt32(tbxFirmaId.Text);
                company.FirmaAdi = tbxFirmaAdi.Text;
                company.FirmaTuru = tbxFirmaTuru.Text;
                company.Adres = tbxAdres.Text;
                company.Telefon = tbxTelefon.Text;
                company.Email = tbxEmail.Text;
                company.YetkiliKisi = tbxYetkiliKisi.Text;
                company.Aciklama = tbxAciklama.Text;
                company.VergiNo = tbxVergiNo.Text;
                company.HesapNo = tbxHesapNo.Text;

                string mesaj = manager.CompanyUpdateBL(company);

                MessageBox.Show(mesaj);

                Listele();

                FormuTemizle();
            }
            else
            {
                MessageBox.Show("Lütfen güncellemek istediğiniz kaydı seçin.");
            }
        }

        private void btnCompanySil_Click(object sender, EventArgs e)
        {
            if (tbxFirmaId.Text != "")
            {
                manager.CompanyDeleteBL(Convert.ToInt32(tbxFirmaId.Text));

                MessageBox.Show("Şirket silindi.");

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
