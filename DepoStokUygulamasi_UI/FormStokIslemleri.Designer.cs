namespace DepoStokUygulamasi_UI
{
    partial class FormStokIslemleri
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
            this.components = new System.ComponentModel.Container();
            this.btnYeniKayıt = new System.Windows.Forms.Button();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxStokIslemId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpIslemTarihi = new System.Windows.Forms.DateTimePicker();
            this.cbxIslemTuru = new System.Windows.Forms.ComboBox();
            this.cbxFirmaAdi = new System.Windows.Forms.ComboBox();
            this.companiesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.depoStokUygulamasiDataSet3 = new DepoStokUygulamasi_UI.DepoStokUygulamasiDataSet3();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnUrunEkle = new System.Windows.Forms.Button();
            this.tbxFiyat = new System.Windows.Forms.TextBox();
            this.tbxAdet = new System.Windows.Forms.TextBox();
            this.cbxUrunAdi = new System.Windows.Forms.ComboBox();
            this.productsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.depoStokUygulamasiDataSet4 = new DepoStokUygulamasi_UI.DepoStokUygulamasiDataSet4();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.companiesTableAdapter = new DepoStokUygulamasi_UI.DepoStokUygulamasiDataSet3TableAdapters.CompaniesTableAdapter();
            this.productsTableAdapter = new DepoStokUygulamasi_UI.DepoStokUygulamasiDataSet4TableAdapters.ProductsTableAdapter();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.rbtnCikisIslemleri = new System.Windows.Forms.RadioButton();
            this.rbtnGirisIslemleri = new System.Windows.Forms.RadioButton();
            this.rbtnTumKayitlar = new System.Windows.Forms.RadioButton();
            this.btnListele = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.companiesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.depoStokUygulamasiDataSet3)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.depoStokUygulamasiDataSet4)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnYeniKayıt
            // 
            this.btnYeniKayıt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYeniKayıt.Location = new System.Drawing.Point(12, 12);
            this.btnYeniKayıt.Name = "btnYeniKayıt";
            this.btnYeniKayıt.Size = new System.Drawing.Size(104, 29);
            this.btnYeniKayıt.TabIndex = 0;
            this.btnYeniKayıt.Text = "Yeni Kayıt";
            this.btnYeniKayıt.UseVisualStyleBackColor = true;
            this.btnYeniKayıt.Click += new System.EventHandler(this.btnYeniKayıt_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKaydet.Location = new System.Drawing.Point(122, 12);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(104, 29);
            this.btnKaydet.TabIndex = 0;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGuncelle.Location = new System.Drawing.Point(232, 12);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(104, 29);
            this.btnGuncelle.TabIndex = 0;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnSil
            // 
            this.btnSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSil.Location = new System.Drawing.Point(342, 12);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(104, 29);
            this.btnSil.TabIndex = 0;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Stok İşlem Id";
            // 
            // tbxStokIslemId
            // 
            this.tbxStokIslemId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxStokIslemId.Location = new System.Drawing.Point(115, 57);
            this.tbxStokIslemId.Name = "tbxStokIslemId";
            this.tbxStokIslemId.Size = new System.Drawing.Size(100, 24);
            this.tbxStokIslemId.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(12, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "İşlem Tarihi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(379, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 18);
            this.label3.TabIndex = 1;
            this.label3.Text = "İşlem Türü";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(379, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 18);
            this.label4.TabIndex = 1;
            this.label4.Text = "Firma Adı";
            // 
            // dtpIslemTarihi
            // 
            this.dtpIslemTarihi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtpIslemTarihi.Location = new System.Drawing.Point(115, 101);
            this.dtpIslemTarihi.Name = "dtpIslemTarihi";
            this.dtpIslemTarihi.Size = new System.Drawing.Size(234, 24);
            this.dtpIslemTarihi.TabIndex = 3;
            // 
            // cbxIslemTuru
            // 
            this.cbxIslemTuru.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbxIslemTuru.FormattingEnabled = true;
            this.cbxIslemTuru.Items.AddRange(new object[] {
            "Giriş İşlemi",
            "Çıkış İşlemi"});
            this.cbxIslemTuru.Location = new System.Drawing.Point(495, 55);
            this.cbxIslemTuru.Name = "cbxIslemTuru";
            this.cbxIslemTuru.Size = new System.Drawing.Size(121, 26);
            this.cbxIslemTuru.TabIndex = 4;
            // 
            // cbxFirmaAdi
            // 
            this.cbxFirmaAdi.DataSource = this.companiesBindingSource;
            this.cbxFirmaAdi.DisplayMember = "FirmaAdi";
            this.cbxFirmaAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbxFirmaAdi.FormattingEnabled = true;
            this.cbxFirmaAdi.Location = new System.Drawing.Point(495, 99);
            this.cbxFirmaAdi.Name = "cbxFirmaAdi";
            this.cbxFirmaAdi.Size = new System.Drawing.Size(121, 26);
            this.cbxFirmaAdi.TabIndex = 4;
            this.cbxFirmaAdi.ValueMember = "Id";
            // 
            // companiesBindingSource
            // 
            this.companiesBindingSource.DataMember = "Companies";
            this.companiesBindingSource.DataSource = this.depoStokUygulamasiDataSet3;
            // 
            // depoStokUygulamasiDataSet3
            // 
            this.depoStokUygulamasiDataSet3.DataSetName = "DepoStokUygulamasiDataSet3";
            this.depoStokUygulamasiDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.btnUrunEkle);
            this.groupBox1.Controls.Add(this.tbxFiyat);
            this.groupBox1.Controls.Add(this.tbxAdet);
            this.groupBox1.Controls.Add(this.cbxUrunAdi);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(15, 161);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(601, 378);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ayrıntılar";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(18, 156);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(558, 192);
            this.dataGridView1.TabIndex = 4;
            // 
            // btnUrunEkle
            // 
            this.btnUrunEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUrunEkle.Location = new System.Drawing.Point(361, 72);
            this.btnUrunEkle.Name = "btnUrunEkle";
            this.btnUrunEkle.Size = new System.Drawing.Size(100, 31);
            this.btnUrunEkle.TabIndex = 3;
            this.btnUrunEkle.Text = "Ürün Ekle";
            this.btnUrunEkle.UseVisualStyleBackColor = true;
            this.btnUrunEkle.Click += new System.EventHandler(this.btnUrunEkle_Click);
            // 
            // tbxFiyat
            // 
            this.tbxFiyat.Location = new System.Drawing.Point(361, 31);
            this.tbxFiyat.Name = "tbxFiyat";
            this.tbxFiyat.Size = new System.Drawing.Size(100, 24);
            this.tbxFiyat.TabIndex = 2;
            // 
            // tbxAdet
            // 
            this.tbxAdet.Location = new System.Drawing.Point(100, 74);
            this.tbxAdet.Name = "tbxAdet";
            this.tbxAdet.Size = new System.Drawing.Size(100, 24);
            this.tbxAdet.TabIndex = 2;
            // 
            // cbxUrunAdi
            // 
            this.cbxUrunAdi.DataSource = this.productsBindingSource;
            this.cbxUrunAdi.DisplayMember = "UrunAdi";
            this.cbxUrunAdi.FormattingEnabled = true;
            this.cbxUrunAdi.Location = new System.Drawing.Point(100, 29);
            this.cbxUrunAdi.Name = "cbxUrunAdi";
            this.cbxUrunAdi.Size = new System.Drawing.Size(121, 26);
            this.cbxUrunAdi.TabIndex = 1;
            this.cbxUrunAdi.ValueMember = "Id";
            // 
            // productsBindingSource
            // 
            this.productsBindingSource.DataMember = "Products";
            this.productsBindingSource.DataSource = this.depoStokUygulamasiDataSet4;
            // 
            // depoStokUygulamasiDataSet4
            // 
            this.depoStokUygulamasiDataSet4.DataSetName = "DepoStokUygulamasiDataSet4";
            this.depoStokUygulamasiDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(298, 37);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 16);
            this.label7.TabIndex = 0;
            this.label7.Text = "Fiyat";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(15, 80);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 16);
            this.label6.TabIndex = 0;
            this.label6.Text = "Adet";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(15, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "Ürün Seç";
            // 
            // companiesTableAdapter
            // 
            this.companiesTableAdapter.ClearBeforeFill = true;
            // 
            // productsTableAdapter
            // 
            this.productsTableAdapter.ClearBeforeFill = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView2);
            this.groupBox2.Controls.Add(this.rbtnCikisIslemleri);
            this.groupBox2.Controls.Add(this.rbtnGirisIslemleri);
            this.groupBox2.Controls.Add(this.rbtnTumKayitlar);
            this.groupBox2.Controls.Add(this.btnListele);
            this.groupBox2.Location = new System.Drawing.Point(646, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(437, 527);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(26, 130);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(398, 383);
            this.dataGridView2.TabIndex = 2;
            this.dataGridView2.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellDoubleClick);
            // 
            // rbtnCikisIslemleri
            // 
            this.rbtnCikisIslemleri.AutoSize = true;
            this.rbtnCikisIslemleri.Location = new System.Drawing.Point(178, 85);
            this.rbtnCikisIslemleri.Name = "rbtnCikisIslemleri";
            this.rbtnCikisIslemleri.Size = new System.Drawing.Size(162, 20);
            this.rbtnCikisIslemleri.TabIndex = 1;
            this.rbtnCikisIslemleri.TabStop = true;
            this.rbtnCikisIslemleri.Text = "Çıkış İşlemlerini Listele";
            this.rbtnCikisIslemleri.UseVisualStyleBackColor = true;
            // 
            // rbtnGirisIslemleri
            // 
            this.rbtnGirisIslemleri.AutoSize = true;
            this.rbtnGirisIslemleri.Location = new System.Drawing.Point(178, 59);
            this.rbtnGirisIslemleri.Name = "rbtnGirisIslemleri";
            this.rbtnGirisIslemleri.Size = new System.Drawing.Size(160, 20);
            this.rbtnGirisIslemleri.TabIndex = 1;
            this.rbtnGirisIslemleri.TabStop = true;
            this.rbtnGirisIslemleri.Text = "Giriş İşlemlerini Listele";
            this.rbtnGirisIslemleri.UseVisualStyleBackColor = true;
            // 
            // rbtnTumKayitlar
            // 
            this.rbtnTumKayitlar.AutoSize = true;
            this.rbtnTumKayitlar.Location = new System.Drawing.Point(178, 33);
            this.rbtnTumKayitlar.Name = "rbtnTumKayitlar";
            this.rbtnTumKayitlar.Size = new System.Drawing.Size(147, 20);
            this.rbtnTumKayitlar.TabIndex = 1;
            this.rbtnTumKayitlar.TabStop = true;
            this.rbtnTumKayitlar.Text = "Tüm Kayıtları Listele";
            this.rbtnTumKayitlar.UseVisualStyleBackColor = true;
            // 
            // btnListele
            // 
            this.btnListele.Location = new System.Drawing.Point(21, 33);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(104, 46);
            this.btnListele.TabIndex = 0;
            this.btnListele.Text = "Listele";
            this.btnListele.UseVisualStyleBackColor = true;
            this.btnListele.Click += new System.EventHandler(this.btnListele_Click);
            // 
            // FormStokIslemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1095, 551);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cbxFirmaAdi);
            this.Controls.Add(this.cbxIslemTuru);
            this.Controls.Add(this.dtpIslemTarihi);
            this.Controls.Add(this.tbxStokIslemId);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.btnYeniKayıt);
            this.Name = "FormStokIslemleri";
            this.Text = "FormStokIslemleri";
            this.Load += new System.EventHandler(this.FormStokIslemleri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.companiesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.depoStokUygulamasiDataSet3)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.depoStokUygulamasiDataSet4)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnYeniKayıt;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxStokIslemId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpIslemTarihi;
        private System.Windows.Forms.ComboBox cbxIslemTuru;
        private System.Windows.Forms.ComboBox cbxFirmaAdi;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnUrunEkle;
        private System.Windows.Forms.TextBox tbxFiyat;
        private System.Windows.Forms.TextBox tbxAdet;
        private System.Windows.Forms.ComboBox cbxUrunAdi;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private DepoStokUygulamasiDataSet3 depoStokUygulamasiDataSet3;
        private System.Windows.Forms.BindingSource companiesBindingSource;
        private DepoStokUygulamasiDataSet3TableAdapters.CompaniesTableAdapter companiesTableAdapter;
        private DepoStokUygulamasiDataSet4 depoStokUygulamasiDataSet4;
        private System.Windows.Forms.BindingSource productsBindingSource;
        private DepoStokUygulamasiDataSet4TableAdapters.ProductsTableAdapter productsTableAdapter;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.RadioButton rbtnCikisIslemleri;
        private System.Windows.Forms.RadioButton rbtnGirisIslemleri;
        private System.Windows.Forms.RadioButton rbtnTumKayitlar;
        private System.Windows.Forms.Button btnListele;
    }
}