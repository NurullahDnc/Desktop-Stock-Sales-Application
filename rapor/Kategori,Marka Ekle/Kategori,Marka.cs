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

namespace rapor
{
    public partial class Kategoriİslemleri : Form
    {
        public Kategoriİslemleri()
        {
            InitializeComponent();
        }

        SqlConnection bag = new SqlConnection("Data Source=DESKTOP-C6HUCTV\\SQLEXPRESS;Initial Catalog=E-Ticaret-I;Integrated Security=True");
        private void Kategoriİslemleri_Load(object sender, EventArgs e)
        {
            Listele();

        } 
        private void Listele()
        {//kategoriler tablosunu dataGridMarkae verileri cekme
            string KategoriSorgu = ("SELECT * FROM Kategori");
            SqlDataAdapter Kategoriadtr = new SqlDataAdapter(KategoriSorgu, bag);
            DataTable Kategoritable = new DataTable();
            Kategoriadtr.Fill(Kategoritable);
            dataGridKategori.DataSource = Kategoritable;

         //Markalar tablosunu DataGridMarkalare verileri cekme
            string MarkaSorgu = ("SELECT * FROM Marka");
            SqlDataAdapter MarkaAdtr = new SqlDataAdapter(MarkaSorgu, bag);
            DataTable MarkaTable = new DataTable();
            MarkaAdtr.Fill(MarkaTable);
            dataGridMarka.DataSource = MarkaTable;
        }

        private void BtnKategoriEkle_Click(object sender, EventArgs e)
        {//Kategoriler tablosuna veri ekleme
            string sorgu = "INSERT INTO Kategori(KategoriAdi) values(@KategoriAdi)";
            SqlCommand cmd = new SqlCommand(sorgu, bag);
            cmd.Parameters.AddWithValue("KategoriAdi", TbKategoriAdi.Text);
            bag.Open();
            cmd.ExecuteNonQuery();
            Listele();
            //Mesaj
            LblKategoriMesaj.Text = "Başarılı Şekilde Kategori Eklenmistir.";
            LblKategoriMesaj.ForeColor = Color.Green;
            //Temizleme
            TbKategoriAdi.Clear();
            bag.Close();

        }

        private void BtnKategoriSil_Click(object sender, EventArgs e)
        {//Kategoriler tablosunda veri silme 
            string sorgu = "DELETE FROM Kategori WHERE KategoriAdi=@KategoriAdi";
            SqlCommand cmd = new SqlCommand(sorgu, bag);
            cmd.Parameters.AddWithValue("KategoriAdi", TbKategoriAdi.Text);
            bag.Open();
            cmd.ExecuteNonQuery();
            Listele();
            //
            LblKategoriMesaj.Text = "Başarılı Şekilde kategori silinmistir.";
            LblKategoriMesaj.ForeColor = Color.Red;
            //Silme isleminden sonra Tb Temizleme
            TbKategoriAdi.Clear();
            bag.Close();
            


        }
        

        private void dataGridKategori_CellClick(object sender, DataGridViewCellEventArgs e)
        {//Kategoriler , datagride ki veriyi textbox atma
            TbKategoriAdi.Text = dataGridKategori.CurrentRow.Cells[1].Value.ToString();
        }

        private void BtnMarkaEkle_Click(object sender, EventArgs e)
        {//Markalar tablosundaki veriyi datagrigMarkalare verileri cekme
            string sorgu = "INSERT INTO Marka(MarkaAdi)VALUES (@MarkaAdi)";
            SqlCommand cmd = new SqlCommand(sorgu, bag);
            cmd.Parameters.AddWithValue("MarkaAdi", TbMarkaEkle.Text);
            bag.Open();
            cmd.ExecuteNonQuery();
            Listele();
            //mesaj
            LblMarkaMesaj.Text = "Başarılı Şekilde Marka Eklenmistir.";
            LblMarkaMesaj.ForeColor = Color.Green;
            //temizle
            TbMarkaEkle.Clear();
            bag.Close();
        }

        private void BtnMarkaSil_Click(object sender, EventArgs e)
        {//Markalar tablosundaki  veriyi silme 
            string sorgu = "DELETE FROM marka WHERE MarkaAdi=@MarkaAdi";
            SqlCommand cmd = new SqlCommand(sorgu, bag);
            cmd.Parameters.AddWithValue("MarkaAdi", TbMarkaEkle.Text);
            bag.Open();
            cmd.ExecuteNonQuery();
            Listele();
            //mesaj
            LblMarkaMesaj.Text = "Başarılı Şekilde Marka silinmistir.";
            LblMarkaMesaj.ForeColor= Color.Red;
            TbMarkaEkle.Clear();
            bag.Close();
        }

        private void dataGridMarka_CellClick(object sender, DataGridViewCellEventArgs e)
        {//markalar , Datagrid deki veriyi textbox atma
            TbMarkaEkle.Text = dataGridMarka.CurrentRow.Cells[1].Value.ToString();
        }

        private void BtnCıkış_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
