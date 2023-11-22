using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace rapor.Kullanıcı
{
    public partial class kullanıcı : Form
    {
        public kullanıcı()
        {
            InitializeComponent();
        }

        SqlConnection bag = new SqlConnection("Data Source=DESKTOP-C6HUCTV\\SQLEXPRESS;Initial Catalog=E-TicaretG;Integrated Security=True");

        private void BtnLogin_Click(object sender, EventArgs e)
        {//sql baglanarak giris yapma
           
            bag.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Kullanıcı WHERE KullanıcıAdi = @KullanıcıAdi AND KullanıcıSifre=@KullanıcıSifre",bag);
            cmd.Parameters.AddWithValue("@KullanıcıAdi", TbKullanıcıAdi.Text);
            cmd.Parameters.AddWithValue("kullanıcıSifre", TbSifre.Text);
            SqlDataReader dr = cmd.ExecuteReader();
            
            if (dr.Read())
            {
                AnaSayfa form = new AnaSayfa();
                form.ShowDialog();
                form.Hide();

            }
            else
            {
                MessageBox.Show("Kullanıcı Adi Veya Sifreniz Hatalıdır.","uyarı",MessageBoxButtons.OK ,MessageBoxIcon.Warning);
            }
            bag.Close();

            
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {//sifre gizle goster

            if (checkBox1.CheckState == CheckState.Checked)
            {
                TbSifre.UseSystemPasswordChar = true;
                checkBox1.Text = "gizle";
            }
            else if (checkBox1.CheckState == CheckState.Unchecked)
            {
                TbSifre.UseSystemPasswordChar = false;
                checkBox1.Text = "goster";
            }

        }

        //textbox yazılara hover ozeligi verme
        private void TbKullanıcıAdi_Enter(object sender, EventArgs e)
        {
            if (TbKullanıcıAdi.Text == "Kullanıcı Adi")
                TbKullanıcıAdi.Text = "";
        }

        private void TbKullanıcıAdi_Leave(object sender, EventArgs e)
        {
            if (TbKullanıcıAdi.Text == "")
                TbKullanıcıAdi.Text = "Kullanıcı Adi";
        }

        private void TbSifre_Enter(object sender, EventArgs e)
        {
            if (TbSifre.Text == "Sifre")
                TbSifre.Text = "";
        }

        private void TbSifre_Leave(object sender, EventArgs e)
        {
            if (TbSifre.Text == "")
                TbSifre.Text = "Sifre";
        }

        //Login Yazısı ust
        private void label1_MouseMove(object sender, MouseEventArgs e)
        {
            label2.Visible = true;
        }

        private void kullanıcı_Load(object sender, EventArgs e)
        {
            label2.Visible = false;
        }

        
    }
}
