namespace rapor.Kullanıcı
{
    partial class kullanıcı
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
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TbKullanıcıAdi = new System.Windows.Forms.TextBox();
            this.BtnLogin = new System.Windows.Forms.Button();
            this.TbSifre = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel1.Controls.Add(this.checkBox1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.TbKullanıcıAdi);
            this.panel1.Controls.Add(this.BtnLogin);
            this.panel1.Controls.Add(this.TbSifre);
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(383, 43);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(669, 649);
            this.panel1.TabIndex = 6;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.checkBox1.Location = new System.Drawing.Point(462, 293);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(110, 22);
            this.checkBox1.TabIndex = 11;
            this.checkBox1.Text = "Sifre Göster";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(232, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 1);
            this.label2.TabIndex = 10;
            this.label2.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(232, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 30);
            this.label1.TabIndex = 9;
            this.label1.Text = "Admin Giriş";
            this.label1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.label1_MouseMove);
            // 
            // TbKullanıcıAdi
            // 
            this.TbKullanıcıAdi.BackColor = System.Drawing.Color.White;
            this.TbKullanıcıAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TbKullanıcıAdi.ForeColor = System.Drawing.Color.Gray;
            this.TbKullanıcıAdi.Location = new System.Drawing.Point(173, 204);
            this.TbKullanıcıAdi.Multiline = true;
            this.TbKullanıcıAdi.Name = "TbKullanıcıAdi";
            this.TbKullanıcıAdi.Size = new System.Drawing.Size(262, 39);
            this.TbKullanıcıAdi.TabIndex = 5;
            this.TbKullanıcıAdi.Text = "Kullanıcı Adi";
            this.TbKullanıcıAdi.Enter += new System.EventHandler(this.TbKullanıcıAdi_Enter);
            this.TbKullanıcıAdi.Leave += new System.EventHandler(this.TbKullanıcıAdi_Leave);
            // 
            // BtnLogin
            // 
            this.BtnLogin.BackColor = System.Drawing.Color.Black;
            this.BtnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnLogin.Location = new System.Drawing.Point(220, 383);
            this.BtnLogin.Name = "BtnLogin";
            this.BtnLogin.Size = new System.Drawing.Size(160, 44);
            this.BtnLogin.TabIndex = 7;
            this.BtnLogin.Text = "Giriş";
            this.BtnLogin.UseVisualStyleBackColor = false;
            this.BtnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // TbSifre
            // 
            this.TbSifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TbSifre.ForeColor = System.Drawing.Color.Gray;
            this.TbSifre.Location = new System.Drawing.Point(173, 284);
            this.TbSifre.Multiline = true;
            this.TbSifre.Name = "TbSifre";
            this.TbSifre.Size = new System.Drawing.Size(262, 46);
            this.TbSifre.TabIndex = 6;
            this.TbSifre.Text = "Sifre";
            this.TbSifre.Enter += new System.EventHandler(this.TbSifre_Enter);
            this.TbSifre.Leave += new System.EventHandler(this.TbSifre_Leave);
            // 
            // kullanıcı
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1434, 735);
            this.Controls.Add(this.panel1);
            this.Name = "kullanıcı";
            this.Text = "kullanıcı";
            this.Load += new System.EventHandler(this.kullanıcı_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TbKullanıcıAdi;
        private System.Windows.Forms.Button BtnLogin;
        private System.Windows.Forms.TextBox TbSifre;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}