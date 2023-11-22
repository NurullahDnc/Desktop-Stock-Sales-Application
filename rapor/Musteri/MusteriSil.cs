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
    public partial class MusteriSil : Form
    {
        public MusteriSil()
        {
            InitializeComponent();
        }

        SqlConnection bag = new SqlConnection("Data Source=DESKTOP-C6HUCTV\\SQLEXPRESS;Initial Catalog=E-Ticaret-I;Integrated Security=True");

        private void MüşteriSil_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void Listele()
        {
            //datagridviev cekme

            string sorgu = "select * from Uye";
            SqlDataAdapter adtr = new SqlDataAdapter(sorgu, bag);
            DataTable table = new DataTable();
            adtr.Fill(table);
            dataGridView1.DataSource = table;
        }

        private void BtnSil_Click(object sender, EventArgs e)
        { // sartlı Sil
            if (TbMüşteriId.Text.Length>0)
            {  
                bag.Open();
                string sorgu = "DELETE FROM Uye WHERE UyeNo=@UyeNo";
                SqlCommand cmd = new SqlCommand(sorgu, bag);
                cmd.Parameters.AddWithValue("@UyeNo", TbMüşteriId.Text);
                cmd.ExecuteNonQuery();
                Listele();
                bag.Close();
                //Mesaj
                LblMesaj.Text = "Başarılı Sekilde Müşteri silinmistir.";
                LblMesaj.ForeColor = Color.Green;
                //Temizle
                TbMüşteriId.Clear();
                
            }
            else
            {
                LblMesaj.Text = "lütfen MüsteriId giriniz.";
                LblMesaj.ForeColor= Color.Red;
            }
         
        }

        private void BtnTemizle_Click(object sender, EventArgs e)
        {
            TbMüşteriId.Clear();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            TbMüşteriId.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
        }

        private void BtnCıkış_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
