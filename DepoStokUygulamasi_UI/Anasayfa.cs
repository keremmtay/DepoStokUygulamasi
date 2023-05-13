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
    public partial class Anasayfa : Form
    {
        public string KullaniciAdi { get; set; } = "Admin";

        public Anasayfa()
        {
            InitializeComponent();
        }

        private void tsbtnUrunIslemleri_Click(object sender, EventArgs e)
        {
            FormProducts formProduct = new FormProducts();

            formProduct.MdiParent = this;

            FormGetir(formProduct);
        }

        private void FormGetir(Form form)
        {
            panel1.Controls.Clear();

            panel1.Controls.Add(form);

            form.FormBorderStyle = FormBorderStyle.None;

            form.Show();
        }

        private void tsbtnFirmaIslemleri_Click(object sender, EventArgs e)
        {
            FormCompany company = new FormCompany();

            company.MdiParent = this;

            FormGetir(company);
        }

        private void tsbtnPersonelIslemleri_Click(object sender, EventArgs e)
        {
            FormEmployee employee = new FormEmployee();

            employee.MdiParent = this;

            FormGetir(employee);
        }

        private void tbstnStokGirisCikisIslemleri_Click(object sender, EventArgs e)
        {
            FormStokIslemleri stokIslemleri = new FormStokIslemleri();

            stokIslemleri.MdiParent = this;

            FormGetir(stokIslemleri);
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Anasayfa_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void kategorilerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormKategori form = new FormKategori();

            form.MdiParent = this;

            FormGetir(form);
        }

        private void ürünlerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormProducts form = new FormProducts();

            form.MdiParent = this;

            FormGetir(form);
        }

        private void firmalarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCompany form = new FormCompany();

            form.MdiParent = this;

            FormGetir(form);
        }

        private void depolarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormWarehouse form = new FormWarehouse();

            form.MdiParent = this;

            FormGetir(form);
        }

        private void birimlerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormUnit form = new FormUnit();

            form.MdiParent = this;

            FormGetir(form);
        }

        private void personellerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormEmployee form = new FormEmployee();

            form.MdiParent = this;

            FormGetir(form);
        }

        private void Anasayfa_Load(object sender, EventArgs e)
        {
            toolStripStatuslblKullaniciAdi.Text = toolStripStatuslblKullaniciAdi.Text + KullaniciAdi;
        }
    }
}
