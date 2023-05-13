namespace DepoStokUygulamasi_UI
{
    partial class FormProducts
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnFormuTemizle = new System.Windows.Forms.Button();
            this.btnProductSil = new System.Windows.Forms.Button();
            this.btnProductGuncelle = new System.Windows.Forms.Button();
            this.btnProductKaydet = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxUrunId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxUrunAdi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbxBarkodKodu = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbxStokMiktarı = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbxBirimFiyat = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbxMaxStok = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tbxMinStok = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tbxRafNo = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cbxKategoriId = new System.Windows.Forms.ComboBox();
            this.cbxDepoId = new System.Windows.Forms.ComboBox();
            this.cbxUnitId = new System.Windows.Forms.ComboBox();
            this.btnBirimEkle = new System.Windows.Forms.Button();
            this.btnDepoEkle = new System.Windows.Forms.Button();
            this.btnKategoriEkle = new System.Windows.Forms.Button();
            this.depoStokUygulamasiDataSet = new DepoStokUygulamasi_UI.DepoStokUygulamasiDataSet();
            this.unitsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.unitsTableAdapter = new DepoStokUygulamasi_UI.DepoStokUygulamasiDataSetTableAdapters.UnitsTableAdapter();
            this.depoStokUygulamasiDataSet1 = new DepoStokUygulamasi_UI.DepoStokUygulamasiDataSet1();
            this.warehousesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.warehousesTableAdapter = new DepoStokUygulamasi_UI.DepoStokUygulamasiDataSet1TableAdapters.WarehousesTableAdapter();
            this.depoStokUygulamasiDataSet2 = new DepoStokUygulamasi_UI.DepoStokUygulamasiDataSet2();
            this.categoriesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.categoriesTableAdapter = new DepoStokUygulamasi_UI.DepoStokUygulamasiDataSet2TableAdapters.CategoriesTableAdapter();
            this.label12 = new System.Windows.Forms.Label();
            this.tbxUrunAra = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.depoStokUygulamasiDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unitsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.depoStokUygulamasiDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.warehousesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.depoStokUygulamasiDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 276);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(837, 293);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // btnFormuTemizle
            // 
            this.btnFormuTemizle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnFormuTemizle.Location = new System.Drawing.Point(709, 231);
            this.btnFormuTemizle.Name = "btnFormuTemizle";
            this.btnFormuTemizle.Size = new System.Drawing.Size(140, 39);
            this.btnFormuTemizle.TabIndex = 1;
            this.btnFormuTemizle.Text = "Formu Temizle";
            this.btnFormuTemizle.UseVisualStyleBackColor = true;
            this.btnFormuTemizle.Click += new System.EventHandler(this.btnFormuTemizle_Click);
            // 
            // btnProductSil
            // 
            this.btnProductSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnProductSil.Location = new System.Drawing.Point(709, 186);
            this.btnProductSil.Name = "btnProductSil";
            this.btnProductSil.Size = new System.Drawing.Size(140, 39);
            this.btnProductSil.TabIndex = 1;
            this.btnProductSil.Text = "Sil";
            this.btnProductSil.UseVisualStyleBackColor = true;
            this.btnProductSil.Click += new System.EventHandler(this.btnProductSil_Click);
            // 
            // btnProductGuncelle
            // 
            this.btnProductGuncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnProductGuncelle.Location = new System.Drawing.Point(709, 140);
            this.btnProductGuncelle.Name = "btnProductGuncelle";
            this.btnProductGuncelle.Size = new System.Drawing.Size(140, 39);
            this.btnProductGuncelle.TabIndex = 1;
            this.btnProductGuncelle.Text = "Güncelle";
            this.btnProductGuncelle.UseVisualStyleBackColor = true;
            this.btnProductGuncelle.Click += new System.EventHandler(this.btnProductGuncelle_Click);
            // 
            // btnProductKaydet
            // 
            this.btnProductKaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnProductKaydet.Location = new System.Drawing.Point(709, 95);
            this.btnProductKaydet.Name = "btnProductKaydet";
            this.btnProductKaydet.Size = new System.Drawing.Size(140, 39);
            this.btnProductKaydet.TabIndex = 1;
            this.btnProductKaydet.Text = "Kaydet";
            this.btnProductKaydet.UseVisualStyleBackColor = true;
            this.btnProductKaydet.Click += new System.EventHandler(this.btnProductKaydet_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ürün Id";
            // 
            // tbxUrunId
            // 
            this.tbxUrunId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxUrunId.Location = new System.Drawing.Point(127, 44);
            this.tbxUrunId.Name = "tbxUrunId";
            this.tbxUrunId.ReadOnly = true;
            this.tbxUrunId.Size = new System.Drawing.Size(79, 24);
            this.tbxUrunId.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(12, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ürün Adı";
            // 
            // tbxUrunAdi
            // 
            this.tbxUrunAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxUrunAdi.Location = new System.Drawing.Point(127, 78);
            this.tbxUrunAdi.Name = "tbxUrunAdi";
            this.tbxUrunAdi.Size = new System.Drawing.Size(121, 24);
            this.tbxUrunAdi.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(12, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Barkod Kodu";
            // 
            // tbxBarkodKodu
            // 
            this.tbxBarkodKodu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxBarkodKodu.Location = new System.Drawing.Point(127, 153);
            this.tbxBarkodKodu.Name = "tbxBarkodKodu";
            this.tbxBarkodKodu.Size = new System.Drawing.Size(121, 24);
            this.tbxBarkodKodu.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(12, 193);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 18);
            this.label4.TabIndex = 2;
            this.label4.Text = "Stok Miktarı";
            // 
            // tbxStokMiktarı
            // 
            this.tbxStokMiktarı.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxStokMiktarı.Location = new System.Drawing.Point(127, 187);
            this.tbxStokMiktarı.Name = "tbxStokMiktarı";
            this.tbxStokMiktarı.Size = new System.Drawing.Size(79, 24);
            this.tbxStokMiktarı.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(12, 227);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 18);
            this.label5.TabIndex = 2;
            this.label5.Text = "Birim Fiyatı";
            // 
            // tbxBirimFiyat
            // 
            this.tbxBirimFiyat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxBirimFiyat.Location = new System.Drawing.Point(127, 221);
            this.tbxBirimFiyat.Name = "tbxBirimFiyat";
            this.tbxBirimFiyat.Size = new System.Drawing.Size(79, 24);
            this.tbxBirimFiyat.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(352, 190);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 18);
            this.label6.TabIndex = 2;
            this.label6.Text = "Max Stok";
            // 
            // tbxMaxStok
            // 
            this.tbxMaxStok.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxMaxStok.Location = new System.Drawing.Point(467, 184);
            this.tbxMaxStok.Name = "tbxMaxStok";
            this.tbxMaxStok.Size = new System.Drawing.Size(71, 24);
            this.tbxMaxStok.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(12, 121);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 18);
            this.label7.TabIndex = 2;
            this.label7.Text = "Kategori";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(352, 153);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 18);
            this.label8.TabIndex = 2;
            this.label8.Text = "Min Stok";
            // 
            // tbxMinStok
            // 
            this.tbxMinStok.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxMinStok.Location = new System.Drawing.Point(467, 147);
            this.tbxMinStok.Name = "tbxMinStok";
            this.tbxMinStok.Size = new System.Drawing.Size(71, 24);
            this.tbxMinStok.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(352, 115);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 18);
            this.label9.TabIndex = 2;
            this.label9.Text = "Depo";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(352, 78);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 18);
            this.label10.TabIndex = 2;
            this.label10.Text = "Raf No";
            // 
            // tbxRafNo
            // 
            this.tbxRafNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxRafNo.Location = new System.Drawing.Point(467, 72);
            this.tbxRafNo.Name = "tbxRafNo";
            this.tbxRafNo.Size = new System.Drawing.Size(71, 24);
            this.tbxRafNo.TabIndex = 3;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(352, 44);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(42, 18);
            this.label11.TabIndex = 2;
            this.label11.Text = "Birim";
            // 
            // cbxKategoriId
            // 
            this.cbxKategoriId.DataSource = this.categoriesBindingSource;
            this.cbxKategoriId.DisplayMember = "KategoriAdi";
            this.cbxKategoriId.FormattingEnabled = true;
            this.cbxKategoriId.Location = new System.Drawing.Point(127, 115);
            this.cbxKategoriId.Name = "cbxKategoriId";
            this.cbxKategoriId.Size = new System.Drawing.Size(121, 24);
            this.cbxKategoriId.TabIndex = 4;
            this.cbxKategoriId.ValueMember = "Id";
            this.cbxKategoriId.Click += new System.EventHandler(this.cbxKategoriId_Click);
            // 
            // cbxDepoId
            // 
            this.cbxDepoId.DataSource = this.warehousesBindingSource;
            this.cbxDepoId.DisplayMember = "DepoAdi";
            this.cbxDepoId.FormattingEnabled = true;
            this.cbxDepoId.Location = new System.Drawing.Point(467, 109);
            this.cbxDepoId.Name = "cbxDepoId";
            this.cbxDepoId.Size = new System.Drawing.Size(121, 24);
            this.cbxDepoId.TabIndex = 4;
            this.cbxDepoId.ValueMember = "Id";
            this.cbxDepoId.Click += new System.EventHandler(this.cbxDepoId_Click);
            // 
            // cbxUnitId
            // 
            this.cbxUnitId.DataSource = this.unitsBindingSource;
            this.cbxUnitId.DisplayMember = "BirimAdi";
            this.cbxUnitId.FormattingEnabled = true;
            this.cbxUnitId.Location = new System.Drawing.Point(467, 38);
            this.cbxUnitId.Name = "cbxUnitId";
            this.cbxUnitId.Size = new System.Drawing.Size(121, 24);
            this.cbxUnitId.TabIndex = 4;
            this.cbxUnitId.ValueMember = "Id";
            this.cbxUnitId.Click += new System.EventHandler(this.cbxUnitId_Click);
            // 
            // btnBirimEkle
            // 
            this.btnBirimEkle.Location = new System.Drawing.Point(610, 38);
            this.btnBirimEkle.Name = "btnBirimEkle";
            this.btnBirimEkle.Size = new System.Drawing.Size(75, 23);
            this.btnBirimEkle.TabIndex = 5;
            this.btnBirimEkle.Text = "Ekle";
            this.btnBirimEkle.UseVisualStyleBackColor = true;
            this.btnBirimEkle.Click += new System.EventHandler(this.btnBirimEkle_Click);
            // 
            // btnDepoEkle
            // 
            this.btnDepoEkle.Location = new System.Drawing.Point(610, 109);
            this.btnDepoEkle.Name = "btnDepoEkle";
            this.btnDepoEkle.Size = new System.Drawing.Size(75, 23);
            this.btnDepoEkle.TabIndex = 5;
            this.btnDepoEkle.Text = "Ekle";
            this.btnDepoEkle.UseVisualStyleBackColor = true;
            this.btnDepoEkle.Click += new System.EventHandler(this.btnDepoEkle_Click);
            // 
            // btnKategoriEkle
            // 
            this.btnKategoriEkle.Location = new System.Drawing.Point(254, 115);
            this.btnKategoriEkle.Name = "btnKategoriEkle";
            this.btnKategoriEkle.Size = new System.Drawing.Size(75, 23);
            this.btnKategoriEkle.TabIndex = 5;
            this.btnKategoriEkle.Text = "Ekle";
            this.btnKategoriEkle.UseVisualStyleBackColor = true;
            this.btnKategoriEkle.Click += new System.EventHandler(this.btnKategoriEkle_Click);
            // 
            // depoStokUygulamasiDataSet
            // 
            this.depoStokUygulamasiDataSet.DataSetName = "DepoStokUygulamasiDataSet";
            this.depoStokUygulamasiDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // unitsBindingSource
            // 
            this.unitsBindingSource.DataMember = "Units";
            this.unitsBindingSource.DataSource = this.depoStokUygulamasiDataSet;
            // 
            // unitsTableAdapter
            // 
            this.unitsTableAdapter.ClearBeforeFill = true;
            // 
            // depoStokUygulamasiDataSet1
            // 
            this.depoStokUygulamasiDataSet1.DataSetName = "DepoStokUygulamasiDataSet1";
            this.depoStokUygulamasiDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // warehousesBindingSource
            // 
            this.warehousesBindingSource.DataMember = "Warehouses";
            this.warehousesBindingSource.DataSource = this.depoStokUygulamasiDataSet1;
            // 
            // warehousesTableAdapter
            // 
            this.warehousesTableAdapter.ClearBeforeFill = true;
            // 
            // depoStokUygulamasiDataSet2
            // 
            this.depoStokUygulamasiDataSet2.DataSetName = "DepoStokUygulamasiDataSet2";
            this.depoStokUygulamasiDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // categoriesBindingSource
            // 
            this.categoriesBindingSource.DataMember = "Categories";
            this.categoriesBindingSource.DataSource = this.depoStokUygulamasiDataSet2;
            // 
            // categoriesTableAdapter
            // 
            this.categoriesTableAdapter.ClearBeforeFill = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.Location = new System.Drawing.Point(352, 227);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(108, 18);
            this.label12.TabIndex = 2;
            this.label12.Text = "Ürün Adı ile Ara";
            // 
            // tbxUrunAra
            // 
            this.tbxUrunAra.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxUrunAra.Location = new System.Drawing.Point(467, 221);
            this.tbxUrunAra.Name = "tbxUrunAra";
            this.tbxUrunAra.Size = new System.Drawing.Size(121, 24);
            this.tbxUrunAra.TabIndex = 3;
            this.tbxUrunAra.TextChanged += new System.EventHandler(this.tbxUrunAra_TextChanged);
            // 
            // FormProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(869, 581);
            this.Controls.Add(this.btnKategoriEkle);
            this.Controls.Add(this.btnDepoEkle);
            this.Controls.Add(this.btnBirimEkle);
            this.Controls.Add(this.cbxUnitId);
            this.Controls.Add(this.cbxDepoId);
            this.Controls.Add(this.cbxKategoriId);
            this.Controls.Add(this.tbxRafNo);
            this.Controls.Add(this.tbxMinStok);
            this.Controls.Add(this.tbxUrunAra);
            this.Controls.Add(this.tbxMaxStok);
            this.Controls.Add(this.tbxBirimFiyat);
            this.Controls.Add(this.tbxStokMiktarı);
            this.Controls.Add(this.tbxBarkodKodu);
            this.Controls.Add(this.tbxUrunAdi);
            this.Controls.Add(this.tbxUrunId);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnProductKaydet);
            this.Controls.Add(this.btnProductGuncelle);
            this.Controls.Add(this.btnProductSil);
            this.Controls.Add(this.btnFormuTemizle);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormProducts";
            this.Text = "FormProducts";
            this.Load += new System.EventHandler(this.FormProducts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.depoStokUygulamasiDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unitsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.depoStokUygulamasiDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.warehousesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.depoStokUygulamasiDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnFormuTemizle;
        private System.Windows.Forms.Button btnProductSil;
        private System.Windows.Forms.Button btnProductGuncelle;
        private System.Windows.Forms.Button btnProductKaydet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxUrunId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxUrunAdi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbxBarkodKodu;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbxStokMiktarı;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbxBirimFiyat;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbxMaxStok;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbxMinStok;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbxRafNo;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cbxKategoriId;
        private System.Windows.Forms.ComboBox cbxDepoId;
        private System.Windows.Forms.ComboBox cbxUnitId;
        private System.Windows.Forms.Button btnBirimEkle;
        private System.Windows.Forms.Button btnDepoEkle;
        private System.Windows.Forms.Button btnKategoriEkle;
        private DepoStokUygulamasiDataSet depoStokUygulamasiDataSet;
        private System.Windows.Forms.BindingSource unitsBindingSource;
        private DepoStokUygulamasiDataSetTableAdapters.UnitsTableAdapter unitsTableAdapter;
        private DepoStokUygulamasiDataSet1 depoStokUygulamasiDataSet1;
        private System.Windows.Forms.BindingSource warehousesBindingSource;
        private DepoStokUygulamasiDataSet1TableAdapters.WarehousesTableAdapter warehousesTableAdapter;
        private DepoStokUygulamasiDataSet2 depoStokUygulamasiDataSet2;
        private System.Windows.Forms.BindingSource categoriesBindingSource;
        private DepoStokUygulamasiDataSet2TableAdapters.CategoriesTableAdapter categoriesTableAdapter;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tbxUrunAra;
    }
}