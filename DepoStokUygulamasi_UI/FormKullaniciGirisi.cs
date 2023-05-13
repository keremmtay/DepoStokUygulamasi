using BusinessLayer.Concrete;
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
    public partial class FormKullaniciGirisi : Form
    {
        public FormKullaniciGirisi()
        {
            InitializeComponent();
        }

        EmployeeManager manager = new EmployeeManager();

        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            if (manager.IsUserExists(tbxKullaniciAdi.Text))
            {
                if (manager.CheckUserNameAndPassword(tbxKullaniciAdi.Text, tbxSifre.Text))
                {
                    MessageBox.Show("Giriş başarılı.");

                    // Anasayfa formu açılacak
                                       
                    Anasayfa form = new Anasayfa();

                    form.KullaniciAdi = tbxKullaniciAdi.Text;

                    form.Show(); // Ana sayfa formunu açıyorum

                    this.Hide(); // Kullanıcı adı girişi formunu gizliyorum
                }
                else
                {
                    MessageBox.Show("Kullanıcı adı ya da şifre hatalı.");

                    tbxKullaniciAdi.Clear();
                    tbxSifre.Clear();
                }

                
            }
            else
            {
                MessageBox.Show("Bu kullanıcı mevcut değil.");

                tbxKullaniciAdi.Clear();
                tbxSifre.Clear();
            }
        }
    }
}
