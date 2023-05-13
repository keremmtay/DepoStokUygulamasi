namespace DepoStokUygulamasi_UI
{
    partial class FormEmployee
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbxSoyadi = new System.Windows.Forms.TextBox();
            this.tbxAdi = new System.Windows.Forms.TextBox();
            this.tbxEmployeeId = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEmployeeKaydet = new System.Windows.Forms.Button();
            this.btnEmployeeGuncelle = new System.Windows.Forms.Button();
            this.btnEmployeeSil = new System.Windows.Forms.Button();
            this.btnFormuTemizle = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbxGorevi = new System.Windows.Forms.TextBox();
            this.tbxKullaniciAdi = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbxSifre = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbxAktifMi = new System.Windows.Forms.CheckBox();
            this.btnAktifPersonelListele = new System.Windows.Forms.Button();
            this.btnAktifOlmayanPersonelListele = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tbxSoyadi
            // 
            this.tbxSoyadi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxSoyadi.Location = new System.Drawing.Point(166, 95);
            this.tbxSoyadi.Name = "tbxSoyadi";
            this.tbxSoyadi.Size = new System.Drawing.Size(100, 24);
            this.tbxSoyadi.TabIndex = 36;
            // 
            // tbxAdi
            // 
            this.tbxAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxAdi.Location = new System.Drawing.Point(166, 58);
            this.tbxAdi.Name = "tbxAdi";
            this.tbxAdi.Size = new System.Drawing.Size(100, 24);
            this.tbxAdi.TabIndex = 35;
            // 
            // tbxEmployeeId
            // 
            this.tbxEmployeeId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxEmployeeId.Location = new System.Drawing.Point(166, 24);
            this.tbxEmployeeId.Name = "tbxEmployeeId";
            this.tbxEmployeeId.ReadOnly = true;
            this.tbxEmployeeId.Size = new System.Drawing.Size(100, 24);
            this.tbxEmployeeId.TabIndex = 34;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(51, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 18);
            this.label3.TabIndex = 33;
            this.label3.Text = "Soyadı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(51, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 18);
            this.label2.TabIndex = 32;
            this.label2.Text = "Adı";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(51, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 18);
            this.label1.TabIndex = 31;
            this.label1.Text = "Unit Id";
            // 
            // btnEmployeeKaydet
            // 
            this.btnEmployeeKaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEmployeeKaydet.Location = new System.Drawing.Point(897, 182);
            this.btnEmployeeKaydet.Name = "btnEmployeeKaydet";
            this.btnEmployeeKaydet.Size = new System.Drawing.Size(178, 66);
            this.btnEmployeeKaydet.TabIndex = 29;
            this.btnEmployeeKaydet.Text = "Kaydet";
            this.btnEmployeeKaydet.UseVisualStyleBackColor = true;
            this.btnEmployeeKaydet.Click += new System.EventHandler(this.btnEmployeeKaydet_Click);
            // 
            // btnEmployeeGuncelle
            // 
            this.btnEmployeeGuncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEmployeeGuncelle.Location = new System.Drawing.Point(897, 254);
            this.btnEmployeeGuncelle.Name = "btnEmployeeGuncelle";
            this.btnEmployeeGuncelle.Size = new System.Drawing.Size(178, 66);
            this.btnEmployeeGuncelle.TabIndex = 28;
            this.btnEmployeeGuncelle.Text = "Güncelle";
            this.btnEmployeeGuncelle.UseVisualStyleBackColor = true;
            this.btnEmployeeGuncelle.Click += new System.EventHandler(this.btnEmployeeGuncelle_Click);
            // 
            // btnEmployeeSil
            // 
            this.btnEmployeeSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEmployeeSil.Location = new System.Drawing.Point(897, 326);
            this.btnEmployeeSil.Name = "btnEmployeeSil";
            this.btnEmployeeSil.Size = new System.Drawing.Size(178, 66);
            this.btnEmployeeSil.TabIndex = 27;
            this.btnEmployeeSil.Text = "Sil";
            this.btnEmployeeSil.UseVisualStyleBackColor = true;
            this.btnEmployeeSil.Click += new System.EventHandler(this.btnEmployeeSil_Click);
            // 
            // btnFormuTemizle
            // 
            this.btnFormuTemizle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnFormuTemizle.Location = new System.Drawing.Point(897, 398);
            this.btnFormuTemizle.Name = "btnFormuTemizle";
            this.btnFormuTemizle.Size = new System.Drawing.Size(178, 66);
            this.btnFormuTemizle.TabIndex = 30;
            this.btnFormuTemizle.Text = "Formu Temizle";
            this.btnFormuTemizle.UseVisualStyleBackColor = true;
            this.btnFormuTemizle.Click += new System.EventHandler(this.btnFormuTemizle_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(54, 254);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(837, 210);
            this.dataGridView1.TabIndex = 26;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(308, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 18);
            this.label4.TabIndex = 32;
            this.label4.Text = "Görevi";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(308, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 18);
            this.label5.TabIndex = 33;
            this.label5.Text = "Kullanıcı Adı";
            // 
            // tbxGorevi
            // 
            this.tbxGorevi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxGorevi.Location = new System.Drawing.Point(423, 24);
            this.tbxGorevi.Name = "tbxGorevi";
            this.tbxGorevi.Size = new System.Drawing.Size(100, 24);
            this.tbxGorevi.TabIndex = 35;
            // 
            // tbxKullaniciAdi
            // 
            this.tbxKullaniciAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxKullaniciAdi.Location = new System.Drawing.Point(423, 61);
            this.tbxKullaniciAdi.Name = "tbxKullaniciAdi";
            this.tbxKullaniciAdi.Size = new System.Drawing.Size(100, 24);
            this.tbxKullaniciAdi.TabIndex = 36;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(308, 101);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 18);
            this.label6.TabIndex = 33;
            this.label6.Text = "Şifre";
            // 
            // tbxSifre
            // 
            this.tbxSifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxSifre.Location = new System.Drawing.Point(423, 95);
            this.tbxSifre.Name = "tbxSifre";
            this.tbxSifre.PasswordChar = '*';
            this.tbxSifre.Size = new System.Drawing.Size(100, 24);
            this.tbxSifre.TabIndex = 36;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(578, 30);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 18);
            this.label7.TabIndex = 33;
            this.label7.Text = "AktifMi";
            // 
            // cbxAktifMi
            // 
            this.cbxAktifMi.AutoSize = true;
            this.cbxAktifMi.Location = new System.Drawing.Point(659, 31);
            this.cbxAktifMi.Name = "cbxAktifMi";
            this.cbxAktifMi.Size = new System.Drawing.Size(95, 20);
            this.cbxAktifMi.TabIndex = 37;
            this.cbxAktifMi.Text = "checkBox1";
            this.cbxAktifMi.UseVisualStyleBackColor = true;
            // 
            // btnAktifPersonelListele
            // 
            this.btnAktifPersonelListele.Location = new System.Drawing.Point(54, 205);
            this.btnAktifPersonelListele.Name = "btnAktifPersonelListele";
            this.btnAktifPersonelListele.Size = new System.Drawing.Size(194, 43);
            this.btnAktifPersonelListele.TabIndex = 38;
            this.btnAktifPersonelListele.Text = "Aktif Personel Listele";
            this.btnAktifPersonelListele.UseVisualStyleBackColor = true;
            this.btnAktifPersonelListele.Click += new System.EventHandler(this.btnAktifPersonelListele_Click);
            // 
            // btnAktifOlmayanPersonelListele
            // 
            this.btnAktifOlmayanPersonelListele.Location = new System.Drawing.Point(254, 205);
            this.btnAktifOlmayanPersonelListele.Name = "btnAktifOlmayanPersonelListele";
            this.btnAktifOlmayanPersonelListele.Size = new System.Drawing.Size(214, 43);
            this.btnAktifOlmayanPersonelListele.TabIndex = 38;
            this.btnAktifOlmayanPersonelListele.Text = "Aktif Olmayan Personeli Listele";
            this.btnAktifOlmayanPersonelListele.UseVisualStyleBackColor = true;
            this.btnAktifOlmayanPersonelListele.Click += new System.EventHandler(this.btnAktifOlmayanPersonelListele_Click);
            // 
            // FormEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1114, 493);
            this.Controls.Add(this.btnAktifOlmayanPersonelListele);
            this.Controls.Add(this.btnAktifPersonelListele);
            this.Controls.Add(this.cbxAktifMi);
            this.Controls.Add(this.tbxSifre);
            this.Controls.Add(this.tbxKullaniciAdi);
            this.Controls.Add(this.tbxSoyadi);
            this.Controls.Add(this.tbxGorevi);
            this.Controls.Add(this.tbxAdi);
            this.Controls.Add(this.tbxEmployeeId);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEmployeeKaydet);
            this.Controls.Add(this.btnEmployeeGuncelle);
            this.Controls.Add(this.btnEmployeeSil);
            this.Controls.Add(this.btnFormuTemizle);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormEmployee";
            this.Text = "FormEmployee";
            this.Load += new System.EventHandler(this.FormEmployee_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxSoyadi;
        private System.Windows.Forms.TextBox tbxAdi;
        private System.Windows.Forms.TextBox tbxEmployeeId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEmployeeKaydet;
        private System.Windows.Forms.Button btnEmployeeGuncelle;
        private System.Windows.Forms.Button btnEmployeeSil;
        private System.Windows.Forms.Button btnFormuTemizle;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbxGorevi;
        private System.Windows.Forms.TextBox tbxKullaniciAdi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbxSifre;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox cbxAktifMi;
        private System.Windows.Forms.Button btnAktifPersonelListele;
        private System.Windows.Forms.Button btnAktifOlmayanPersonelListele;
    }
}