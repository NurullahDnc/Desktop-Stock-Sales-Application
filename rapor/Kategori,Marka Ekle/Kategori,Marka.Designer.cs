namespace rapor
{
    partial class Kategoriİslemleri
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnCıkış = new System.Windows.Forms.Button();
            this.BtnGeri = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.BtnMarkaSil = new System.Windows.Forms.Button();
            this.BtnMarkaEkle = new System.Windows.Forms.Button();
            this.TbMarkaEkle = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BtnKategoriSil = new System.Windows.Forms.Button();
            this.BtnKategoriEkle = new System.Windows.Forms.Button();
            this.TbKategoriAdi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridMarka = new System.Windows.Forms.DataGridView();
            this.dataGridKategori = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LblKategoriMesaj = new System.Windows.Forms.Label();
            this.LblMarkaMesaj = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMarka)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridKategori)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel1.Controls.Add(this.BtnCıkış);
            this.panel1.Controls.Add(this.BtnGeri);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(453, 686);
            this.panel1.TabIndex = 0;
            this.panel1.Tag = "";
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // BtnCıkış
            // 
            this.BtnCıkış.Location = new System.Drawing.Point(365, 653);
            this.BtnCıkış.Name = "BtnCıkış";
            this.BtnCıkış.Size = new System.Drawing.Size(85, 30);
            this.BtnCıkış.TabIndex = 8;
            this.BtnCıkış.Text = "Cıkış";
            this.BtnCıkış.UseVisualStyleBackColor = true;
            this.BtnCıkış.Click += new System.EventHandler(this.BtnCıkış_Click);
            // 
            // BtnGeri
            // 
            this.BtnGeri.Location = new System.Drawing.Point(4, 656);
            this.BtnGeri.Name = "BtnGeri";
            this.BtnGeri.Size = new System.Drawing.Size(85, 30);
            this.BtnGeri.TabIndex = 7;
            this.BtnGeri.Text = "Geri";
            this.BtnGeri.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.LblMarkaMesaj);
            this.panel3.Controls.Add(this.BtnMarkaSil);
            this.panel3.Controls.Add(this.BtnMarkaEkle);
            this.panel3.Controls.Add(this.TbMarkaEkle);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Location = new System.Drawing.Point(49, 413);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(323, 203);
            this.panel3.TabIndex = 6;
            // 
            // BtnMarkaSil
            // 
            this.BtnMarkaSil.Location = new System.Drawing.Point(150, 86);
            this.BtnMarkaSil.Name = "BtnMarkaSil";
            this.BtnMarkaSil.Size = new System.Drawing.Size(117, 42);
            this.BtnMarkaSil.TabIndex = 5;
            this.BtnMarkaSil.Text = "Marka sil";
            this.BtnMarkaSil.UseVisualStyleBackColor = true;
            this.BtnMarkaSil.Click += new System.EventHandler(this.BtnMarkaSil_Click);
            // 
            // BtnMarkaEkle
            // 
            this.BtnMarkaEkle.Location = new System.Drawing.Point(19, 86);
            this.BtnMarkaEkle.Name = "BtnMarkaEkle";
            this.BtnMarkaEkle.Size = new System.Drawing.Size(125, 42);
            this.BtnMarkaEkle.TabIndex = 4;
            this.BtnMarkaEkle.Text = "Marka Ekle";
            this.BtnMarkaEkle.UseVisualStyleBackColor = true;
            this.BtnMarkaEkle.Click += new System.EventHandler(this.BtnMarkaEkle_Click);
            // 
            // TbMarkaEkle
            // 
            this.TbMarkaEkle.Location = new System.Drawing.Point(144, 31);
            this.TbMarkaEkle.Name = "TbMarkaEkle";
            this.TbMarkaEkle.Size = new System.Drawing.Size(100, 22);
            this.TbMarkaEkle.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(18, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Marka Adi:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.LblKategoriMesaj);
            this.panel2.Controls.Add(this.BtnKategoriSil);
            this.panel2.Controls.Add(this.BtnKategoriEkle);
            this.panel2.Controls.Add(this.TbKategoriAdi);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(49, 60);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(323, 203);
            this.panel2.TabIndex = 0;
            // 
            // BtnKategoriSil
            // 
            this.BtnKategoriSil.Location = new System.Drawing.Point(150, 79);
            this.BtnKategoriSil.Name = "BtnKategoriSil";
            this.BtnKategoriSil.Size = new System.Drawing.Size(117, 42);
            this.BtnKategoriSil.TabIndex = 5;
            this.BtnKategoriSil.Text = "Kategori sil";
            this.BtnKategoriSil.UseVisualStyleBackColor = true;
            this.BtnKategoriSil.Click += new System.EventHandler(this.BtnKategoriSil_Click);
            // 
            // BtnKategoriEkle
            // 
            this.BtnKategoriEkle.Location = new System.Drawing.Point(20, 79);
            this.BtnKategoriEkle.Name = "BtnKategoriEkle";
            this.BtnKategoriEkle.Size = new System.Drawing.Size(124, 42);
            this.BtnKategoriEkle.TabIndex = 4;
            this.BtnKategoriEkle.Text = "Kateegori Ekle";
            this.BtnKategoriEkle.UseVisualStyleBackColor = true;
            this.BtnKategoriEkle.Click += new System.EventHandler(this.BtnKategoriEkle_Click);
            // 
            // TbKategoriAdi
            // 
            this.TbKategoriAdi.Location = new System.Drawing.Point(144, 24);
            this.TbKategoriAdi.Name = "TbKategoriAdi";
            this.TbKategoriAdi.Size = new System.Drawing.Size(100, 22);
            this.TbKategoriAdi.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(18, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Kategori Adi:";
            // 
            // dataGridMarka
            // 
            this.dataGridMarka.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridMarka.Location = new System.Drawing.Point(459, 444);
            this.dataGridMarka.Name = "dataGridMarka";
            this.dataGridMarka.RowHeadersWidth = 51;
            this.dataGridMarka.RowTemplate.Height = 24;
            this.dataGridMarka.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridMarka.Size = new System.Drawing.Size(947, 228);
            this.dataGridMarka.TabIndex = 1;
            this.dataGridMarka.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridMarka_CellClick);
            // 
            // dataGridKategori
            // 
            this.dataGridKategori.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridKategori.Location = new System.Drawing.Point(459, 79);
            this.dataGridKategori.Name = "dataGridKategori";
            this.dataGridKategori.RowHeadersWidth = 51;
            this.dataGridKategori.RowTemplate.Height = 24;
            this.dataGridKategori.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridKategori.Size = new System.Drawing.Size(947, 224);
            this.dataGridKategori.TabIndex = 2;
            this.dataGridKategori.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridKategori_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(735, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(316, 42);
            this.label1.TabIndex = 3;
            this.label1.Text = "KATEGORİ EKLE";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label3.Location = new System.Drawing.Point(773, 353);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(257, 42);
            this.label3.TabIndex = 5;
            this.label3.Text = "MARKA EKLE";
            // 
            // LblKategoriMesaj
            // 
            this.LblKategoriMesaj.AutoSize = true;
            this.LblKategoriMesaj.Location = new System.Drawing.Point(19, 152);
            this.LblKategoriMesaj.Name = "LblKategoriMesaj";
            this.LblKategoriMesaj.Size = new System.Drawing.Size(14, 16);
            this.LblKategoriMesaj.TabIndex = 6;
            this.LblKategoriMesaj.Text = " /";
            // 
            // LblMarkaMesaj
            // 
            this.LblMarkaMesaj.AutoSize = true;
            this.LblMarkaMesaj.Location = new System.Drawing.Point(19, 157);
            this.LblMarkaMesaj.Name = "LblMarkaMesaj";
            this.LblMarkaMesaj.Size = new System.Drawing.Size(14, 16);
            this.LblMarkaMesaj.TabIndex = 7;
            this.LblMarkaMesaj.Text = " /";
            // 
            // Kategoriİslemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1408, 686);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridKategori);
            this.Controls.Add(this.dataGridMarka);
            this.Controls.Add(this.panel1);
            this.Name = "Kategoriİslemleri";
            this.Text = "2";
            this.Load += new System.EventHandler(this.Kategoriİslemleri_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMarka)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridKategori)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridMarka;
        private System.Windows.Forms.DataGridView dataGridKategori;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TbKategoriAdi;
        private System.Windows.Forms.Button BtnKategoriSil;
        private System.Windows.Forms.Button BtnKategoriEkle;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button BtnMarkaSil;
        private System.Windows.Forms.Button BtnMarkaEkle;
        private System.Windows.Forms.TextBox TbMarkaEkle;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BtnCıkış;
        private System.Windows.Forms.Button BtnGeri;
        private System.Windows.Forms.Label LblKategoriMesaj;
        private System.Windows.Forms.Label LblMarkaMesaj;
    }
}