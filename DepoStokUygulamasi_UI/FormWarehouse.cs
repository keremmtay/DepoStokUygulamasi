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
    public partial class FormWarehouse : Form
    {
        public FormWarehouse()
        {
            InitializeComponent();
        }

        WarehouseManager manager = new WarehouseManager();

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            tbxDepoId.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            tbxDepoAdi.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            tbxAciklama.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            tbxDepoYetkilisi.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            tbxTelefon.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
        }
        private void FormuTemizle()
        {
            tbxDepoId.Clear();
            tbxDepoAdi.Clear();
            tbxAciklama.Clear();
            tbxDepoYetkilisi.Clear();
            tbxTelefon.Clear();
        }

        private void Listele()
        {
            dataGridView1.DataSource = manager.GetAllBL();
        }

        private void FormWarehouse_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void btnFormuTemizle_Click(object sender, EventArgs e)
        {
            FormuTemizle();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            Warehouse warehouse = new Warehouse();
            warehouse.DepoAdi = tbxDepoAdi.Text;
            warehouse.DepoYetkilisi = tbxDepoYetkilisi.Text;
            warehouse.Aciklama = tbxAciklama.Text;
            warehouse.Telefon = tbxTelefon.Text;

            string mesaj = manager.WarehouseAddBL(warehouse);

            MessageBox.Show(mesaj);

            Listele();

            FormuTemizle();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (tbxDepoId.Text != "")
            {
                Warehouse warehouse = new Warehouse();
                warehouse.Id = Convert.ToInt32(tbxDepoId.Text);
                warehouse.DepoAdi = tbxDepoAdi.Text;
                warehouse.DepoYetkilisi = tbxDepoYetkilisi.Text;
                warehouse.Aciklama = tbxAciklama.Text;
                warehouse.Telefon = tbxTelefon.Text;

                string mesaj = manager.WarehouseUpdateBL(warehouse);

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
            if (tbxDepoId.Text != string.Empty)
            {
                manager.WarehouseDeleteBL(Convert.ToInt32(tbxDepoId.Text));

                MessageBox.Show("Depo silindi.");

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
