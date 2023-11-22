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

namespace rapor.Kullanıcı
{
    public partial class YeniKulanıcı : Form
    {
        public YeniKulanıcı()
        {
            InitializeComponent();
        }

        SqlConnection bag = new SqlConnection("Data Source=DESKTOP-C6HUCTV\\SQLEXPRESS;Initial Catalog=E-TicaretG;Integrated Security=True");

        private void YeniKulanıcı_Load(object sender, EventArgs e)
        {
            Listele();

        }

        private void Listele()
        {
            String sorgu = ("SELECT * FROM Kullanıcı");
            SqlDataAdapter adtr = new SqlDataAdapter(sorgu, bag);
            DataTable table = new DataTable();
            adtr.Fill(table);
            dataGridView1.DataSource = table;
        }

        private void BtnEkle_Click(object sender, EventArgs e)
        {//ekle
            string sorgu = "INSERT INTO Kullanıcı(KullanıcıAdi, KullanıcıSifre) VALUES (@KullanıcıAdi,@KullanıcıSifre)";
            SqlCommand cmd = new SqlCommand(sorgu, bag);
            cmd.Parameters.AddWithValue("@KullanıcıAdi", TbKullanıcıAdi.Text);
            cmd.Parameters.AddWithValue("@kullanıcıSifre", TbKullanıcıSifre.Text);
            bag.Open();
            cmd.ExecuteNonQuery();
            Listele();
            //mesaj
            LblMesaj.Text = "Başarılı Sekilde Kullanıcı Eklenmistir.";
            LblMesaj.ForeColor = Color.Green;
            //temizle
            TbKullanıcıAdi.Clear();
            TbKullanıcıSifre.Clear();
            bag.Close();


        }

        private void BtnSil_Click(object sender, EventArgs e)
        {//sil
            bag.Open();
            string sorgu = "DELETE FROM Kullanıcı WHERE KullanıcıAdi=@KullanıcıAdi";
            SqlCommand cmd = new SqlCommand(sorgu, bag);
            cmd.Parameters.AddWithValue("@KullanıcıAdi   ", TbKullanıcıAdi.Text);
            cmd.ExecuteNonQuery();
            Listele();
            //mesaj
            LblMesaj.Text = "Başarılı Sekilde Kullanıcı Silinmistir.";
            LblMesaj.ForeColor = Color.Green;
            //temizle
            TbKullanıcıAdi.Clear();
            TbKullanıcıSifre.Clear();
            bag.Close();


        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {//textboxlara veriyi cekeme
            TbKullanıcıAdi.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            TbKullanıcıSifre.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {//guncelleme
            string sorgu = ("UPDATE Kullanıcı SET KullanıcıAdi=@KullanıcıAdi, KullanıcıSifre=@KullanıcıSifre WHERE KullanıcıAdi=@KullanıcıAdi");
            SqlCommand cmd = new SqlCommand(sorgu, bag);
            cmd.Parameters.AddWithValue("@KullanıcıAdi", TbKullanıcıAdi.Text);
            cmd.Parameters.AddWithValue("@KullanıcıSifre", TbKullanıcıSifre.Text);
            bag.Open();
            cmd.ExecuteNonQuery();
            Listele();
            //mesaj
            LblMesaj.Text = "Başarılı Sekilde Kullanıcı Guncelenmistir.";
            LblMesaj.ForeColor = Color.Green;
            //temizle
            TbKullanıcıAdi.Clear();
            TbKullanıcıSifre.Clear();
            bag.Close();
        }
    }
}
