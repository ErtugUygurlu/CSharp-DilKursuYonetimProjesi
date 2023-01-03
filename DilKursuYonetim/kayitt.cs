using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace DilKursuYonetim
{
    public partial class kayitt : Form
    {
        public kayitt()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-ORL2PMQ\SQLEXPRESS;Initial Catalog=kurs;Integrated Security=True");

        private void kayitt_Load(object sender, EventArgs e)
        {
            uyeler();
        }
        private void uyeler()
        {
            baglanti.Open();
            string query = "select * from OgrenciTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, baglanti);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            OgrenciDgv.DataSource = ds.Tables[0];
            baglanti.Close();
        }

        private void ResimYukleBtn_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            OgrenciPb.ImageLocation = openFileDialog1.FileName;
            OgrenciResimTb.Text = openFileDialog1.FileName;
        }

        private void EkleBtn_Click(object sender, EventArgs e)
        {
            if (OgrenciAdTb.Text == "" || OgrenciTelefonTb.Text == "" || OgrenciResimTb.Text == "" || OgrenciCinsiyetCb.Text == "" || OgrenciAdresTb.Text == "")
            {
                MessageBox.Show("Eksik Bilgi Girdiniz");
            }
            else
            {
                try
                {
                    baglanti.Open();
                    string query = "insert into OgrenciTbl values('" + OgrenciAdTb.Text + "','" + OgrenciTelefonTb.Text + "','" + OgrenciDogumTimeB.Text + "','" + OgrenciCinsiyetCb.Text + "','" + OgrenciResimTb.Text + "','" + OgrenciAdresTb.Text + "')";
                    SqlCommand komut = new SqlCommand(query, baglanti);
                    komut.ExecuteNonQuery();
                    MessageBox.Show("Öğrenci Başarıyla Eklendi");
                    baglanti.Close();
                    uyeler();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void ResetBtn_Click(object sender, EventArgs e)
        {
            OgrenciAdTb.Text = "";
            OgrenciTelefonTb.Text = "";
            OgrenciDogumTimeB.Text = "";
            OgrenciCinsiyetCb.Text = "";
            OgrenciResimTb.Text = "";
            OgrenciAdresTb.Text = "";
        }

        private void GeriBtn_Click(object sender, EventArgs e)
        {
            Anasayfa ana = new Anasayfa();
            ana.Show();
            this.Hide();
        }
    }
}
