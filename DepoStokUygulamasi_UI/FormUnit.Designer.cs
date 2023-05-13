namespace DepoStokUygulamasi_UI
{
    partial class FormUnit
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
            this.tbxAciklama = new System.Windows.Forms.TextBox();
            this.tbxBirimAdi = new System.Windows.Forms.TextBox();
            this.tbxUnitId = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnUnitKaydet = new System.Windows.Forms.Button();
            this.btnUnitGuncelle = new System.Windows.Forms.Button();
            this.btnUnitSil = new System.Windows.Forms.Button();
            this.btnFormuTemizle = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tbxAciklama
            // 
            this.tbxAciklama.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxAciklama.Location = new System.Drawing.Point(163, 92);
            this.tbxAciklama.Name = "tbxAciklama";
            this.tbxAciklama.Size = new System.Drawing.Size(100, 24);
            this.tbxAciklama.TabIndex = 25;
            // 
            // tbxBirimAdi
            // 
            this.tbxBirimAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxBirimAdi.Location = new System.Drawing.Point(163, 55);
            this.tbxBirimAdi.Name = "tbxBirimAdi";
            this.tbxBirimAdi.Size = new System.Drawing.Size(100, 24);
            this.tbxBirimAdi.TabIndex = 21;
            // 
            // tbxUnitId
            // 
            this.tbxUnitId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxUnitId.Location = new System.Drawing.Point(163, 21);
            this.tbxUnitId.Name = "tbxUnitId";
            this.tbxUnitId.ReadOnly = true;
            this.tbxUnitId.Size = new System.Drawing.Size(100, 24);
            this.tbxUnitId.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(48, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 18);
            this.label3.TabIndex = 14;
            this.label3.Text = "Açıklama";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(48, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 18);
            this.label2.TabIndex = 10;
            this.label2.Text = "Birim Adı";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(48, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 18);
            this.label1.TabIndex = 9;
            this.label1.Text = "Unit Id";
            // 
            // btnUnitKaydet
            // 
            this.btnUnitKaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUnitKaydet.Location = new System.Drawing.Point(51, 145);
            this.btnUnitKaydet.Name = "btnUnitKaydet";
            this.btnUnitKaydet.Size = new System.Drawing.Size(178, 47);
            this.btnUnitKaydet.TabIndex = 7;
            this.btnUnitKaydet.Text = "Kaydet";
            this.btnUnitKaydet.UseVisualStyleBackColor = true;
            this.btnUnitKaydet.Click += new System.EventHandler(this.btnUnitKaydet_Click);
            // 
            // btnUnitGuncelle
            // 
            this.btnUnitGuncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUnitGuncelle.Location = new System.Drawing.Point(235, 145);
            this.btnUnitGuncelle.Name = "btnUnitGuncelle";
            this.btnUnitGuncelle.Size = new System.Drawing.Size(178, 47);
            this.btnUnitGuncelle.TabIndex = 6;
            this.btnUnitGuncelle.Text = "Güncelle";
            this.btnUnitGuncelle.UseVisualStyleBackColor = true;
            this.btnUnitGuncelle.Click += new System.EventHandler(this.btnUnitGuncelle_Click);
            // 
            // btnUnitSil
            // 
            this.btnUnitSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUnitSil.Location = new System.Drawing.Point(419, 145);
            this.btnUnitSil.Name = "btnUnitSil";
            this.btnUnitSil.Size = new System.Drawing.Size(178, 47);
            this.btnUnitSil.TabIndex = 5;
            this.btnUnitSil.Text = "Sil";
            this.btnUnitSil.UseVisualStyleBackColor = true;
            this.btnUnitSil.Click += new System.EventHandler(this.btnUnitSil_Click);
            // 
            // btnFormuTemizle
            // 
            this.btnFormuTemizle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnFormuTemizle.Location = new System.Drawing.Point(603, 145);
            this.btnFormuTemizle.Name = "btnFormuTemizle";
            this.btnFormuTemizle.Size = new System.Drawing.Size(178, 47);
            this.btnFormuTemizle.TabIndex = 8;
            this.btnFormuTemizle.Text = "Formu Temizle";
            this.btnFormuTemizle.UseVisualStyleBackColor = true;
            this.btnFormuTemizle.Click += new System.EventHandler(this.btnFormuTemizle_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(51, 212);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(730, 196);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // FormUnit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 442);
            this.Controls.Add(this.tbxAciklama);
            this.Controls.Add(this.tbxBirimAdi);
            this.Controls.Add(this.tbxUnitId);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnUnitKaydet);
            this.Controls.Add(this.btnUnitGuncelle);
            this.Controls.Add(this.btnUnitSil);
            this.Controls.Add(this.btnFormuTemizle);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormUnit";
            this.Text = "FormUnit";
            this.Load += new System.EventHandler(this.FormUnit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxAciklama;
        private System.Windows.Forms.TextBox tbxBirimAdi;
        private System.Windows.Forms.TextBox tbxUnitId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnUnitKaydet;
        private System.Windows.Forms.Button btnUnitGuncelle;
        private System.Windows.Forms.Button btnUnitSil;
        private System.Windows.Forms.Button btnFormuTemizle;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}