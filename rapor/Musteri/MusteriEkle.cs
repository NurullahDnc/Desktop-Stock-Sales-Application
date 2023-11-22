using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace rapor
{
    public partial class MusteriEkle : Form
    {

        public MusteriEkle()
        {
            InitializeComponent();
        }
        //sql bag
        SqlConnection bag = new SqlConnection("Data Source=DESKTOP-C6HUCTV\\SQLEXPRESS;Initial Catalog=E-Ticaret-I;Integrated Security=True");
        string Cinsiyet;
        private void Müşteri_Load(object sender, EventArgs e)
        {
            //load da olusturması icin metod olusturuldu
            Listele();

        }

        private void Listele()
        {
            string sorgu = "select * from Uye";
            SqlDataAdapter adtr = new SqlDataAdapter(sorgu, bag);
            DataTable table = new DataTable();
            adtr.Fill(table);
            dataGridView1.DataSource = table;
        }


        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            //EKLE

            if (TbAd.Text.Length > 0)
            {
                String sorgu = "INSERT INTO Uye(UyeNo, UyeAdi, UyeSoyadi, UyeTelefonNo, UyeCinsiyet, UyeE_Mail, UyeSifre, UyeTarih) VALUES (@UyeNo, @UyeAdi, @UyeSoyadi, @UyeTelefonNo, @UyeCinsiyet,  @UyeE_Mail, @UyeSifre, @UyeTarih)";
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
                cmd.Parameters.AddWithValue("@UyeTarih", DtTarih.Value);

                bag.Open();
                cmd.ExecuteNonQuery();
                Listele();
                //Mesaj
                LblMesaj.Text = "Başarılı seklide ürün eklenmistir";
                LblMesaj.ForeColor = Color.Green;

                //eklem sonrası tb leri temizleme

                TbNo.Clear();
                TbAd.Clear();
                TbSoyad.Clear();
                TbTelefonNo.Clear();
                TbEmail.Clear();
                TbSifre.ResetText();
                RbErkek.Checked = false;
                RbKadın.Checked = false;
            }
            else
            {
                LblMesaj.Text = "Kayıt yapmak icin deger giriniz";
                LblMesaj.ForeColor = Color.Red;
            }

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            //TbMusteriNo.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
        }


        private void BtnTemizle_Click(object sender, EventArgs e)
        {
            //Temizle
            TbNo.Clear();
            TbAd.Clear();
            TbSoyad.Clear();
            TbTelefonNo.Clear();
            TbEmail.Clear();
            RbErkek.Checked = false;
            RbKadın.Checked = false;
        }

        private void BtnCıkış_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnGeri_Click(object sender, EventArgs e)
        {
            AnaSayfa form = new AnaSayfa();
            form.ShowDialog();
            Close();
        }
    }
}
