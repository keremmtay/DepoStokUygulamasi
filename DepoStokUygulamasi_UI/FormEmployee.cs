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
    public partial class FormEmployee : Form
    {
        public FormEmployee()
        {
            InitializeComponent();
        }

        EmployeeManager manager = new EmployeeManager();

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            tbxEmployeeId.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            tbxAdi.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            tbxSoyadi.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            tbxGorevi.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            tbxKullaniciAdi.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            tbxSifre.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            cbxAktifMi.Checked = Convert.ToBoolean(dataGridView1.CurrentRow.Cells[6].Value);
        }

        private void FormEmployee_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void Listele()
        {
            dataGridView1.DataSource = manager.GetAllBL();
        }

        private void FormuTemizle()
        {
            tbxEmployeeId.Clear();
            tbxAdi.Clear();
            tbxSoyadi.Clear();
            tbxGorevi.Clear();
            tbxKullaniciAdi.Clear();
            tbxSifre.Clear();
            cbxAktifMi.Checked = false;
        }

        private void btnFormuTemizle_Click(object sender, EventArgs e)
        {
            FormuTemizle();
        }

        private void btnEmployeeKaydet_Click(object sender, EventArgs e)
        {
            Employee employee = new Employee();
            employee.Adi = tbxAdi.Text;
            employee.Soyadi = tbxSoyadi.Text;
            employee.Gorevi = tbxGorevi.Text;
            employee.KullaniciAdi = tbxKullaniciAdi.Text;
            employee.Sifre = tbxSifre.Text;
            employee.AktifMi = cbxAktifMi.Checked;

            string mesaj = manager.EmployeeAddBL(employee);

            MessageBox.Show(mesaj);

            Listele();

            FormuTemizle();
        }

        private void btnEmployeeGuncelle_Click(object sender, EventArgs e)
        {
            if (tbxEmployeeId.Text != "")
            {
                Employee employee = new Employee();
                employee.Id = Convert.ToInt32(tbxEmployeeId.Text);
                employee.Adi = tbxAdi.Text;
                employee.Soyadi = tbxSoyadi.Text;
                employee.Gorevi = tbxGorevi.Text;
                employee.KullaniciAdi = tbxKullaniciAdi.Text;
                employee.Sifre = tbxSifre.Text;
                employee.AktifMi = cbxAktifMi.Checked;

                string mesaj = manager.EmployeeUpdateBL(employee);

                MessageBox.Show(mesaj);

                Listele();

                FormuTemizle();
            }
            else
            {
                MessageBox.Show("Lütfen güncellemek istediğiniz kaydı seçin.");
            }
        }

        private void btnEmployeeSil_Click(object sender, EventArgs e)
        {
            if (tbxEmployeeId.Text != "")
            {
                manager.EmployeeDeleteBL(Convert.ToInt32(tbxEmployeeId.Text));

                MessageBox.Show("Çalışan kaydı silindi.");

                Listele();

                FormuTemizle();
            }
            else
            {
                MessageBox.Show("Lütfen silmek istediğiniz kaydı seçin.");
            }
        }

        private void btnAktifPersonelListele_Click(object sender, EventArgs e)
        {
            // Aktif personeli veritabanından sorgulayacak ve gelen sonucu dataGridView içinde listeleyecek

            dataGridView1.DataSource = manager.GetActivePersonels();
        }

        private void btnAktifOlmayanPersonelListele_Click(object sender, EventArgs e)
        {
            // Aktif olmayan personeli veritabanından sorgulayacak ve gelen sonucu dataGridView içinde listeleyecek

            dataGridView1.DataSource = manager.GetNonActivePersonels();
        }
    }
}
