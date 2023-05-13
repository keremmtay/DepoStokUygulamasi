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
    public partial class FormUnit : Form
    {
        public FormUnit()
        {
            InitializeComponent();
        }

        UnitManager manager = new UnitManager();

        private void FormUnit_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void Listele()
        {
            dataGridView1.DataSource = manager.GetAllBL();
        }

        private void btnUnitKaydet_Click(object sender, EventArgs e)
        {
            Unit unit = new Unit();
            unit.BirimAdi = tbxBirimAdi.Text;
            unit.Aciklama = tbxAciklama.Text;

            string mesaj = manager.UnitAddBL(unit);

            MessageBox.Show(mesaj);

            Listele();

            FormuTemizle();
        }

        private void FormuTemizle()
        {
            tbxUnitId.Clear();
            tbxBirimAdi.Clear();
            tbxAciklama.Clear();
        }

        private void btnFormuTemizle_Click(object sender, EventArgs e)
        {
            FormuTemizle();
        }

        private void btnUnitGuncelle_Click(object sender, EventArgs e)
        {
            if (tbxUnitId.Text != "")
            {
                Unit unit = new Unit();
                unit.Id = Convert.ToInt32(tbxUnitId.Text);
                unit.BirimAdi = tbxBirimAdi.Text;
                unit.Aciklama = tbxAciklama.Text;

                string mesaj = manager.UnitUpdateBL(unit);

                MessageBox.Show(mesaj);

                Listele();

                FormuTemizle();
            }
            else
            {
                MessageBox.Show("Lütfen güncellemek istediğiniz kaydı seçin.");
            }
        }

        private void btnUnitSil_Click(object sender, EventArgs e)
        {
            if (tbxUnitId.Text != string.Empty)
            {
                manager.UnitDeleteBL(Convert.ToInt32(tbxUnitId.Text));

                MessageBox.Show("Unit silindi.");

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
            tbxUnitId.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            tbxBirimAdi.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            tbxAciklama.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
        }
    }
}
