namespace rapor
{
    partial class Satis
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnSepeteEkle = new System.Windows.Forms.Button();
            this.BtnÜrünüSil = new System.Windows.Forms.Button();
            this.CbKategoriAdi = new System.Windows.Forms.ComboBox();
            this.CbÜrünAdi = new System.Windows.Forms.ComboBox();
            this.CbMarkaAdi = new System.Windows.Forms.ComboBox();
            this.button3 = new System.Windows.Forms.Button();
            this.BtnCıkıs = new System.Windows.Forms.Button();
            this.DataGridSepet = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TbToplam = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TbAdet = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TbİndirimKodu = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TbSepetFiyatı = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.CbAltKategoriAdi = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridSepet)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(456, 277);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(959, 405);
            this.dataGridView1.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label8.Location = new System.Drawing.Point(786, 96);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(204, 69);
            this.label8.TabIndex = 21;
            this.label8.Text = "SATIŞ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kategori Adi:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ürün Adi:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Marka Adi:";
            // 
            // BtnSepeteEkle
            // 
            this.BtnSepeteEkle.Location = new System.Drawing.Point(28, 173);
            this.BtnSepeteEkle.Name = "BtnSepeteEkle";
            this.BtnSepeteEkle.Size = new System.Drawing.Size(100, 39);
            this.BtnSepeteEkle.TabIndex = 3;
            this.BtnSepeteEkle.Text = "Sepete Ekle";
            this.BtnSepeteEkle.UseVisualStyleBackColor = true;
            this.BtnSepeteEkle.Click += new System.EventHandler(this.BtnSepeteEkle_Click);
            // 
            // BtnÜrünüSil
            // 
            this.BtnÜrünüSil.Location = new System.Drawing.Point(155, 173);
            this.BtnÜrünüSil.Name = "BtnÜrünüSil";
            this.BtnÜrünüSil.Size = new System.Drawing.Size(110, 39);
            this.BtnÜrünüSil.TabIndex = 4;
            this.BtnÜrünüSil.Text = "Ürün Sil";
            this.BtnÜrünüSil.UseVisualStyleBackColor = true;
            // 
            // CbKategoriAdi
            // 
            this.CbKategoriAdi.FormattingEnabled = true;
            this.CbKategoriAdi.Location = new System.Drawing.Point(174, 22);
            this.CbKategoriAdi.Name = "CbKategoriAdi";
            this.CbKategoriAdi.Size = new System.Drawing.Size(226, 26);
            this.CbKategoriAdi.TabIndex = 6;
            // 
            // CbÜrünAdi
            // 
            this.CbÜrünAdi.FormattingEnabled = true;
            this.CbÜrünAdi.Location = new System.Drawing.Point(174, 135);
            this.CbÜrünAdi.Name = "CbÜrünAdi";
            this.CbÜrünAdi.Size = new System.Drawing.Size(226, 26);
            this.CbÜrünAdi.TabIndex = 7;
            // 
            // CbMarkaAdi
            // 
            this.CbMarkaAdi.FormattingEnabled = true;
            this.CbMarkaAdi.Location = new System.Drawing.Point(174, 96);
            this.CbMarkaAdi.Name = "CbMarkaAdi";
            this.CbMarkaAdi.Size = new System.Drawing.Size(226, 26);
            this.CbMarkaAdi.TabIndex = 8;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(103, 601);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(154, 45);
            this.button3.TabIndex = 20;
            this.button3.Text = "Sepeti Onayla";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // BtnCıkıs
            // 
            this.BtnCıkıs.Location = new System.Drawing.Point(366, 643);
            this.BtnCıkıs.Name = "BtnCıkıs";
            this.BtnCıkıs.Size = new System.Drawing.Size(84, 27);
            this.BtnCıkıs.TabIndex = 21;
            this.BtnCıkıs.Text = "Cıkış";
            this.BtnCıkıs.UseVisualStyleBackColor = true;
            // 
            // DataGridSepet
            // 
            this.DataGridSepet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridSepet.Location = new System.Drawing.Point(12, 231);
            this.DataGridSepet.Name = "DataGridSepet";
            this.DataGridSepet.RowHeadersWidth = 51;
            this.DataGridSepet.RowTemplate.Height = 24;
            this.DataGridSepet.Size = new System.Drawing.Size(425, 163);
            this.DataGridSepet.TabIndex = 22;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.TbToplam);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.TbAdet);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.TbİndirimKodu);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.TbSepetFiyatı);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(0, 400);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(450, 111);
            this.panel1.TabIndex = 27;
            // 
            // TbToplam
            // 
            this.TbToplam.Location = new System.Drawing.Point(120, 76);
            this.TbToplam.Name = "TbToplam";
            this.TbToplam.Size = new System.Drawing.Size(75, 24);
            this.TbToplam.TabIndex = 25;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 79);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 18);
            this.label7.TabIndex = 24;
            this.label7.Text = "Toplam:";
            // 
            // TbAdet
            // 
            this.TbAdet.Location = new System.Drawing.Point(120, 12);
            this.TbAdet.Name = "TbAdet";
            this.TbAdet.Size = new System.Drawing.Size(75, 24);
            this.TbAdet.TabIndex = 23;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 18);
            this.label6.TabIndex = 22;
            this.label6.Text = "Adet:";
            // 
            // TbİndirimKodu
            // 
            this.TbİndirimKodu.Location = new System.Drawing.Point(316, 18);
            this.TbİndirimKodu.Name = "TbİndirimKodu";
            this.TbİndirimKodu.Size = new System.Drawing.Size(124, 24);
            this.TbİndirimKodu.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(221, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 18);
            this.label5.TabIndex = 20;
            this.label5.Text = "İndirim Kodu:";
            // 
            // TbSepetFiyatı
            // 
            this.TbSepetFiyatı.Location = new System.Drawing.Point(120, 45);
            this.TbSepetFiyatı.Name = "TbSepetFiyatı";
            this.TbSepetFiyatı.Size = new System.Drawing.Size(75, 24);
            this.TbSepetFiyatı.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 18);
            this.label4.TabIndex = 18;
            this.label4.Text = "Sepetin Fiyatı:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel2.Controls.Add(this.CbAltKategoriAdi);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.comboBox1);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.DataGridSepet);
            this.panel2.Controls.Add(this.BtnCıkıs);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.CbMarkaAdi);
            this.panel2.Controls.Add(this.CbÜrünAdi);
            this.panel2.Controls.Add(this.CbKategoriAdi);
            this.panel2.Controls.Add(this.BtnÜrünüSil);
            this.panel2.Controls.Add(this.BtnSepeteEkle);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(450, 700);
            this.panel2.TabIndex = 4;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(330, 528);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 24);
            this.textBox1.TabIndex = 43;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(235, 533);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(82, 18);
            this.label10.TabIndex = 42;
            this.label10.Text = "Müşteri Ad:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(120, 533);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(80, 26);
            this.comboBox1.TabIndex = 41;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(20, 533);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(85, 18);
            this.label9.TabIndex = 40;
            this.label9.Text = "Müşteri No:";
            // 
            // CbAltKategoriAdi
            // 
            this.CbAltKategoriAdi.FormattingEnabled = true;
            this.CbAltKategoriAdi.Location = new System.Drawing.Point(174, 58);
            this.CbAltKategoriAdi.Name = "CbAltKategoriAdi";
            this.CbAltKategoriAdi.Size = new System.Drawing.Size(226, 26);
            this.CbAltKategoriAdi.TabIndex = 45;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(25, 61);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(107, 18);
            this.label11.TabIndex = 44;
            this.label11.Text = "AltKategori Adi:";
            // 
            // Satis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1423, 700);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Satis";
            this.Text = "Satiş";
            this.Load += new System.EventHandler(this.Satiş_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridSepet)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnSepeteEkle;
        private System.Windows.Forms.Button BtnÜrünüSil;
        private System.Windows.Forms.ComboBox CbKategoriAdi;
        private System.Windows.Forms.ComboBox CbÜrünAdi;
        private System.Windows.Forms.ComboBox CbMarkaAdi;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button BtnCıkıs;
        private System.Windows.Forms.DataGridView DataGridSepet;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox TbToplam;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TbAdet;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TbİndirimKodu;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TbSepetFiyatı;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox CbAltKategoriAdi;
        private System.Windows.Forms.Label label11;
    }
}