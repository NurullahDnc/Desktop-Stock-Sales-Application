using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace rapor.Müşteriler
{
    public partial class MusteriGuncelle : Form
    {
        public MusteriGuncelle()
        {
            InitializeComponent();
        }
        SqlConnection bag = new SqlConnection("Data Source=DESKTOP-C6HUCTV\\SQLEXPRESS;Initial Catalog=E-Ticaret-I;Integrated Security=True");
        string Cinsiyet;


        private void MüşteriGuncelle_Load(object sender, EventArgs e)
        {//load da yenilenmesi icin 
            Listele();

        }

        private void Listele()
        {//musteriler tablosundaki verileri datagridvieew cekme
            string sorgu = "select * from Uye";
            SqlDataAdapter adtr = new SqlDataAdapter(sorgu, bag);
            DataTable table = new DataTable();
            adtr.Fill(table);
            dataGridView1.DataSource = table;
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            //Guncelle
            string sorgu = "UPDATE Uye SET UyeNo=@UyeNo, UyeAdi=@UyeAdi, UyeSoyadi=@UyeSoyadi, UyeTelefonNo=@UyeTelefonNo, UyeE_Mail=@UyeE_Mail, UyeSifre=@UyeSifre, UyeCinsiyet=@UyeCinsiyet WHERE UyeNo=@UyeNo";
            SqlCommand cmd = new SqlCommand(sorgu, bag);
            cmd.Parameters.AddWithValue("@UyeNo", TbNo.Text);
            cmd.Parameters.AddWithValue("@UyeAdi", TbAd.Text);
            cmd.Parameters.AddWithValue("@UyeSoyadi", TbSoyad.Text);
            cmd.Parameters.AddWithValue("@UyeTelefonNo", TbTelefonNo.Text);
            cmd.Parameters.AddWithValue("@UyeE_Mail", TbEmail.Text);
            cmd.Parameters.AddWithValue("@UyeSifre", TbSifre.Text);
            if (RbErkek.Checked)
            {
                Cinsiyet = "Erkek";
            }
            else if (RbKadın.Checked)
            {
                Cinsiyet = "Kadın";
            }
            cmd.Parameters.AddWithValue("@UyeCinsiyet", Cinsiyet);

            bag.Open();
            cmd.ExecuteNonQuery();
            Listele();
            bag.Close();
            //mesaj
            LblMesaj.Text = "Başarılı Sekilde Müşteri Guncelllenmistir.";
            LblMesaj.ForeColor = Color.Green;

            //Temizle
            TbNo.Clear();
            TbAd.Clear();
            TbSoyad.Clear();
            TbTelefonNo.Clear();
            TbEmail.Clear();
            RbErkek.Checked = false;
            RbKadın.Checked = false;
            TbSifre.Clear();

        }

        private void BtnTemizle_Click(object sender, EventArgs e)
        {
            //Temizle

            TbAd.Clear();
            TbSoyad.Clear();
            TbTelefonNo.Clear();
            TbEmail.Clear();
            RbErkek.Checked = false;
            RbKadın.Checked = false;
            TbSifre.Clear();
        }

        private void BtnGeri_Click(object sender, EventArgs e)
        {//form da geriye gelme
            AnaSayfa form = new AnaSayfa(); 
            form.ShowDialog();
            Close();

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {//verileri textbox atama

            TbNo.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            TbAd.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            TbSoyad.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            TbTelefonNo.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            TbEmail.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            //TbSifre.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();

        }

        private void BtnCıkış_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
