namespace rapor.Ürünler
{
    partial class UrunGuncelle
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
            this.label11 = new System.Windows.Forms.Label();
            this.BtnCıkış = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.LblMesaj = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.CbAltKategoriAdi = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.BtnTemizle = new System.Windows.Forms.Button();
            this.BtnGuncelle = new System.Windows.Forms.Button();
            this.TbStokAdeti = new System.Windows.Forms.TextBox();
            this.DateKayıtTarihi = new System.Windows.Forms.DateTimePicker();
            this.TbFiyati = new System.Windows.Forms.TextBox();
            this.TbUrunAcıklama = new System.Windows.Forms.TextBox();
            this.TbUrunAdi = new System.Windows.Forms.TextBox();
            this.TbUrunKodu = new System.Windows.Forms.TextBox();
            this.CbMarkaAdi = new System.Windows.Forms.ComboBox();
            this.CbKategoriAdi = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label11.Location = new System.Drawing.Point(668, 92);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(540, 69);
            this.label11.TabIndex = 6;
            this.label11.Text = "ÜRÜN GÜNCELLE";
            // 
            // BtnCıkış
            // 
            this.BtnCıkış.Location = new System.Drawing.Point(360, 625);
            this.BtnCıkış.Name = "BtnCıkış";
            this.BtnCıkış.Size = new System.Drawing.Size(89, 31);
            this.BtnCıkış.TabIndex = 64;
            this.BtnCıkış.Text = "Cıkış";
            this.BtnCıkış.UseVisualStyleBackColor = true;
            this.BtnCıkış.Click += new System.EventHandler(this.BtnCıkış_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(455, 278);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(937, 390);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // LblMesaj
            // 
            this.LblMesaj.AutoSize = true;
            this.LblMesaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblMesaj.Location = new System.Drawing.Point(48, 630);
            this.LblMesaj.Name = "LblMesaj";
            this.LblMesaj.Size = new System.Drawing.Size(12, 18);
            this.LblMesaj.TabIndex = 18;
            this.LblMesaj.Text = "/";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.CbAltKategoriAdi);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.BtnTemizle);
            this.panel2.Controls.Add(this.BtnGuncelle);
            this.panel2.Controls.Add(this.TbStokAdeti);
            this.panel2.Controls.Add(this.DateKayıtTarihi);
            this.panel2.Controls.Add(this.TbFiyati);
            this.panel2.Controls.Add(this.TbUrunAcıklama);
            this.panel2.Controls.Add(this.TbUrunAdi);
            this.panel2.Controls.Add(this.TbUrunKodu);
            this.panel2.Controls.Add(this.CbMarkaAdi);
            this.panel2.Controls.Add(this.CbKategoriAdi);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.BtnCıkış);
            this.panel2.Controls.Add(this.LblMesaj);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(452, 707);
            this.panel2.TabIndex = 5;
            // 
            // CbAltKategoriAdi
            // 
            this.CbAltKategoriAdi.FormattingEnabled = true;
            this.CbAltKategoriAdi.Location = new System.Drawing.Point(199, 54);
            this.CbAltKategoriAdi.Name = "CbAltKategoriAdi";
            this.CbAltKategoriAdi.Size = new System.Drawing.Size(121, 24);
            this.CbAltKategoriAdi.TabIndex = 90;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(48, 54);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(103, 18);
            this.label8.TabIndex = 89;
            this.label8.Text = "AltKategori Adi";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(368, 582);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 31);
            this.button1.TabIndex = 88;
            this.button1.Text = "Cıkış";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // BtnTemizle
            // 
            this.BtnTemizle.Location = new System.Drawing.Point(225, 483);
            this.BtnTemizle.Name = "BtnTemizle";
            this.BtnTemizle.Size = new System.Drawing.Size(110, 47);
            this.BtnTemizle.TabIndex = 87;
            this.BtnTemizle.Text = "Temizle";
            this.BtnTemizle.UseVisualStyleBackColor = true;
            this.BtnTemizle.Click += new System.EventHandler(this.BtnTemizle_Click_1);
            // 
            // BtnGuncelle
            // 
            this.BtnGuncelle.Location = new System.Drawing.Point(59, 483);
            this.BtnGuncelle.Name = "BtnGuncelle";
            this.BtnGuncelle.Size = new System.Drawing.Size(120, 47);
            this.BtnGuncelle.TabIndex = 86;
            this.BtnGuncelle.Text = "Ürün Güncelle";
            this.BtnGuncelle.UseVisualStyleBackColor = true;
            this.BtnGuncelle.Click += new System.EventHandler(this.BtnGuncelle_Click_1);
            // 
            // TbStokAdeti
            // 
            this.TbStokAdeti.Location = new System.Drawing.Point(200, 405);
            this.TbStokAdeti.Name = "TbStokAdeti";
            this.TbStokAdeti.Size = new System.Drawing.Size(100, 22);
            this.TbStokAdeti.TabIndex = 85;
            // 
            // DateKayıtTarihi
            // 
            this.DateKayıtTarihi.Location = new System.Drawing.Point(199, 359);
            this.DateKayıtTarihi.Name = "DateKayıtTarihi";
            this.DateKayıtTarihi.Size = new System.Drawing.Size(200, 22);
            this.DateKayıtTarihi.TabIndex = 83;
            // 
            // TbFiyati
            // 
            this.TbFiyati.Location = new System.Drawing.Point(199, 325);
            this.TbFiyati.Name = "TbFiyati";
            this.TbFiyati.Size = new System.Drawing.Size(100, 22);
            this.TbFiyati.TabIndex = 82;
            // 
            // TbUrunAcıklama
            // 
            this.TbUrunAcıklama.Location = new System.Drawing.Point(199, 245);
            this.TbUrunAcıklama.Multiline = true;
            this.TbUrunAcıklama.Name = "TbUrunAcıklama";
            this.TbUrunAcıklama.Size = new System.Drawing.Size(248, 63);
            this.TbUrunAcıklama.TabIndex = 81;
            // 
            // TbUrunAdi
            // 
            this.TbUrunAdi.Location = new System.Drawing.Point(200, 160);
            this.TbUrunAdi.Multiline = true;
            this.TbUrunAdi.Name = "TbUrunAdi";
            this.TbUrunAdi.Size = new System.Drawing.Size(248, 64);
            this.TbUrunAdi.TabIndex = 80;
            // 
            // TbUrunKodu
            // 
            this.TbUrunKodu.Location = new System.Drawing.Point(200, 124);
            this.TbUrunKodu.Name = "TbUrunKodu";
            this.TbUrunKodu.Size = new System.Drawing.Size(100, 22);
            this.TbUrunKodu.TabIndex = 79;
            // 
            // CbMarkaAdi
            // 
            this.CbMarkaAdi.FormattingEnabled = true;
            this.CbMarkaAdi.Location = new System.Drawing.Point(200, 89);
            this.CbMarkaAdi.Name = "CbMarkaAdi";
            this.CbMarkaAdi.Size = new System.Drawing.Size(121, 24);
            this.CbMarkaAdi.TabIndex = 78;
            // 
            // CbKategoriAdi
            // 
            this.CbKategoriAdi.FormattingEnabled = true;
            this.CbKategoriAdi.Location = new System.Drawing.Point(199, 20);
            this.CbKategoriAdi.Name = "CbKategoriAdi";
            this.CbKategoriAdi.Size = new System.Drawing.Size(121, 24);
            this.CbKategoriAdi.TabIndex = 77;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(48, 164);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 18);
            this.label5.TabIndex = 76;
            this.label5.Text = "Ürün Adı";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(48, 21);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 18);
            this.label7.TabIndex = 75;
            this.label7.Text = "Kategori Id/Adi";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(48, 409);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(75, 18);
            this.label10.TabIndex = 74;
            this.label10.Text = "Stok Adeti";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(48, 362);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 18);
            this.label1.TabIndex = 72;
            this.label1.Text = "Kayıt Tarihi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(106, 565);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 18);
            this.label2.TabIndex = 71;
            this.label2.Text = "label8";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(48, 325);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 18);
            this.label6.TabIndex = 70;
            this.label6.Text = "Fiyati";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(46, 245);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 18);
            this.label4.TabIndex = 69;
            this.label4.Text = "Ürün Acıklama";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(48, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 18);
            this.label3.TabIndex = 68;
            this.label3.Text = "Marka Id/Adi";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.Location = new System.Drawing.Point(48, 129);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(79, 18);
            this.label12.TabIndex = 67;
            this.label12.Text = "Ürün Kodu";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(306, 124);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(11, 16);
            this.label13.TabIndex = 91;
            this.label13.Text = "/";
            // 
            // ÜrünGuncelle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1386, 707);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel2);
            this.Name = "ÜrünGuncelle";
            this.Text = "ÜrünGuncelle";
            this.Load += new System.EventHandler(this.ÜrünGuncelle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button BtnCıkış;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label LblMesaj;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox CbAltKategoriAdi;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button BtnTemizle;
        private System.Windows.Forms.Button BtnGuncelle;
        private System.Windows.Forms.TextBox TbStokAdeti;
        private System.Windows.Forms.DateTimePicker DateKayıtTarihi;
        private System.Windows.Forms.TextBox TbFiyati;
        private System.Windows.Forms.TextBox TbUrunAcıklama;
        private System.Windows.Forms.TextBox TbUrunAdi;
        private System.Windows.Forms.TextBox TbUrunKodu;
        private System.Windows.Forms.ComboBox CbMarkaAdi;
        private System.Windows.Forms.ComboBox CbKategoriAdi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label12;
    }
}