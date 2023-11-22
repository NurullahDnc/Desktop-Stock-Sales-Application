namespace rapor.Müşteriler
{
    partial class MusteriGuncelle
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
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.BtnTemizle = new System.Windows.Forms.Button();
            this.BtnGeri = new System.Windows.Forms.Button();
            this.BtnCıkış = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.TbNo = new System.Windows.Forms.TextBox();
            this.TbSifre = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.RbKadın = new System.Windows.Forms.RadioButton();
            this.RbErkek = new System.Windows.Forms.RadioButton();
            this.TbEmail = new System.Windows.Forms.TextBox();
            this.TbTelefonNo = new System.Windows.Forms.TextBox();
            this.TbSoyad = new System.Windows.Forms.TextBox();
            this.TbAd = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LblMesaj = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(634, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(525, 54);
            this.label1.TabIndex = 2;
            this.label1.Text = "MÜŞTERİ GUNCELLLE";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(456, 309);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(941, 389);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(44, 448);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(146, 47);
            this.button1.TabIndex = 71;
            this.button1.Text = "Müsteri Guncelle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // BtnTemizle
            // 
            this.BtnTemizle.Location = new System.Drawing.Point(236, 448);
            this.BtnTemizle.Name = "BtnTemizle";
            this.BtnTemizle.Size = new System.Drawing.Size(146, 47);
            this.BtnTemizle.TabIndex = 72;
            this.BtnTemizle.Text = "Temizle";
            this.BtnTemizle.UseVisualStyleBackColor = true;
            this.BtnTemizle.Click += new System.EventHandler(this.BtnTemizle_Click);
            // 
            // BtnGeri
            // 
            this.BtnGeri.Location = new System.Drawing.Point(12, 646);
            this.BtnGeri.Name = "BtnGeri";
            this.BtnGeri.Size = new System.Drawing.Size(89, 31);
            this.BtnGeri.TabIndex = 73;
            this.BtnGeri.Text = "Geri";
            this.BtnGeri.UseVisualStyleBackColor = true;
            this.BtnGeri.Click += new System.EventHandler(this.BtnGeri_Click);
            // 
            // BtnCıkış
            // 
            this.BtnCıkış.Location = new System.Drawing.Point(348, 646);
            this.BtnCıkış.Name = "BtnCıkış";
            this.BtnCıkış.Size = new System.Drawing.Size(89, 31);
            this.BtnCıkış.TabIndex = 74;
            this.BtnCıkış.Text = "Cıkış";
            this.BtnCıkış.UseVisualStyleBackColor = true;
            this.BtnCıkış.Click += new System.EventHandler(this.BtnCıkış_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel2.Controls.Add(this.TbNo);
            this.panel2.Controls.Add(this.TbSifre);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.RbKadın);
            this.panel2.Controls.Add(this.RbErkek);
            this.panel2.Controls.Add(this.TbEmail);
            this.panel2.Controls.Add(this.TbTelefonNo);
            this.panel2.Controls.Add(this.TbSoyad);
            this.panel2.Controls.Add(this.TbAd);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.BtnCıkış);
            this.panel2.Controls.Add(this.BtnGeri);
            this.panel2.Controls.Add(this.BtnTemizle);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.LblMesaj);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(450, 689);
            this.panel2.TabIndex = 4;
            // 
            // TbNo
            // 
            this.TbNo.Location = new System.Drawing.Point(178, 31);
            this.TbNo.Name = "TbNo";
            this.TbNo.Size = new System.Drawing.Size(85, 24);
            this.TbNo.TabIndex = 90;
            // 
            // TbSifre
            // 
            this.TbSifre.Location = new System.Drawing.Point(177, 255);
            this.TbSifre.Name = "TbSifre";
            this.TbSifre.Size = new System.Drawing.Size(172, 24);
            this.TbSifre.TabIndex = 89;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(40, 255);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 18);
            this.label8.TabIndex = 88;
            this.label8.Text = "Sifre";
            // 
            // RbKadın
            // 
            this.RbKadın.AutoSize = true;
            this.RbKadın.Location = new System.Drawing.Point(257, 318);
            this.RbKadın.Name = "RbKadın";
            this.RbKadın.Size = new System.Drawing.Size(66, 22);
            this.RbKadın.TabIndex = 87;
            this.RbKadın.TabStop = true;
            this.RbKadın.Text = "Kadın";
            this.RbKadın.UseVisualStyleBackColor = true;
            // 
            // RbErkek
            // 
            this.RbErkek.AutoSize = true;
            this.RbErkek.Location = new System.Drawing.Point(163, 318);
            this.RbErkek.Name = "RbErkek";
            this.RbErkek.Size = new System.Drawing.Size(68, 22);
            this.RbErkek.TabIndex = 86;
            this.RbErkek.TabStop = true;
            this.RbErkek.Text = "Erkek";
            this.RbErkek.UseVisualStyleBackColor = true;
            // 
            // TbEmail
            // 
            this.TbEmail.Location = new System.Drawing.Point(177, 207);
            this.TbEmail.Name = "TbEmail";
            this.TbEmail.Size = new System.Drawing.Size(235, 24);
            this.TbEmail.TabIndex = 85;
            // 
            // TbTelefonNo
            // 
            this.TbTelefonNo.Location = new System.Drawing.Point(178, 158);
            this.TbTelefonNo.Name = "TbTelefonNo";
            this.TbTelefonNo.Size = new System.Drawing.Size(172, 24);
            this.TbTelefonNo.TabIndex = 84;
            // 
            // TbSoyad
            // 
            this.TbSoyad.Location = new System.Drawing.Point(177, 118);
            this.TbSoyad.Name = "TbSoyad";
            this.TbSoyad.Size = new System.Drawing.Size(172, 24);
            this.TbSoyad.TabIndex = 83;
            // 
            // TbAd
            // 
            this.TbAd.Location = new System.Drawing.Point(178, 74);
            this.TbAd.Name = "TbAd";
            this.TbAd.Size = new System.Drawing.Size(172, 24);
            this.TbAd.TabIndex = 82;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(41, 318);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 18);
            this.label6.TabIndex = 81;
            this.label6.Text = "Cinsiyet:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(40, 207);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 18);
            this.label5.TabIndex = 80;
            this.label5.Text = "E-Mail:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(41, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 18);
            this.label4.TabIndex = 79;
            this.label4.Text = "Telefon No:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(40, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 18);
            this.label3.TabIndex = 78;
            this.label3.Text = "Soyad:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(41, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 18);
            this.label2.TabIndex = 77;
            this.label2.Text = "Ad:";
            // 
            // LblMesaj
            // 
            this.LblMesaj.AutoSize = true;
            this.LblMesaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblMesaj.Location = new System.Drawing.Point(40, 564);
            this.LblMesaj.Name = "LblMesaj";
            this.LblMesaj.Size = new System.Drawing.Size(54, 20);
            this.LblMesaj.TabIndex = 51;
            this.LblMesaj.Text = "Mesaj";
            // 
            // MüşteriGuncelle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1386, 689);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Name = "MüşteriGuncelle";
            this.Text = "MüşteriGuncelle";
            this.Load += new System.EventHandler(this.MüşteriGuncelle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button BtnTemizle;
        private System.Windows.Forms.Button BtnGeri;
        private System.Windows.Forms.Button BtnCıkış;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label LblMesaj;
        private System.Windows.Forms.TextBox TbSifre;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RadioButton RbKadın;
        private System.Windows.Forms.RadioButton RbErkek;
        private System.Windows.Forms.TextBox TbEmail;
        private System.Windows.Forms.TextBox TbTelefonNo;
        private System.Windows.Forms.TextBox TbSoyad;
        private System.Windows.Forms.TextBox TbAd;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TbNo;
    }
}