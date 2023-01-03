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
    public partial class OgrenciYonetim : Form
    {
        public OgrenciYonetim()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-ORL2PMQ\SQLEXPRESS;Initial Catalog=kurs;Integrated Security=True");

        private void button5_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from OgrenciTbl where AdSoyad like '%" + FilterTb.Text + "%'", baglanti);
            SqlDataAdapter sda = new SqlDataAdapter(komut);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            YonetimDgv.DataSource = ds.Tables[0];
            baglanti.Close();
        }

        private void OgrenciYonetim_Load(object sender, EventArgs e)
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
            YonetimDgv.DataSource = ds.Tables[0];
            baglanti.Close();
        }
        int OgrKey;
        private void button2_Click(object sender, EventArgs e)
        {
            if (AdSoyadTb.Text == "" || TelefonTb.Text == "" || ResimTb.Text == "" || CinsiyetCb.Text == "" || AdresTb.Text == "")
            {
                MessageBox.Show("Silinecek Öğrenciyi Seçiniz");
            }
            else
            {
                try
                {
                    OgrKey = Convert.ToInt32(YonetimDgv.SelectedRows[0].Cells[0].Value.ToString());
                    baglanti.Open();
                    string query = "delete from OgrenciTbl where OgrenciId=" + OgrKey + "";
                    SqlCommand komut = new SqlCommand(query, baglanti);
                    komut.ExecuteNonQuery();
                    MessageBox.Show("Öğrenci Başarıyla Silindi");
                    baglanti.Close();
                    uyeler();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void YonetimDgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            OgrKey = Convert.ToInt32(YonetimDgv.SelectedRows[0].Cells[0].Value.ToString());
            AdSoyadTb.Text = YonetimDgv.SelectedRows[0].Cells[1].Value.ToString();
            TelefonTb.Text = YonetimDgv.SelectedRows[0].Cells[2].Value.ToString();
            DogumTime.Text = YonetimDgv.SelectedRows[0].Cells[3].Value.ToString();
            CinsiyetCb.Text = YonetimDgv.SelectedRows[0].Cells[4].Value.ToString();
            ResimTb.Text = YonetimDgv.SelectedRows[0].Cells[5].Value.ToString();
            AdresTb.Text = YonetimDgv.SelectedRows[0].Cells[6].Value.ToString();
            YonetimPb.ImageLocation = YonetimDgv.SelectedRows[0].Cells[5].Value.ToString();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (AdSoyadTb.Text == "" || TelefonTb.Text == "" || ResimTb.Text == "" || CinsiyetCb.Text == "" || AdresTb.Text == "")
            {
                MessageBox.Show("Eksik Bilgi");
            }
            else
            {
                try
                {
                    baglanti.Open();
                    string query = "update OgrenciTbl set AdSoyad='" + AdSoyadTb.Text + "',Telefon='" + TelefonTb.Text + "',DogumTrh='" + DogumTime.Text + "',Cinsiyet='" + CinsiyetCb.Text + "',Resim='" + ResimTb.Text + "',Adres='" + AdresTb.Text + "'where OgrenciId=" + OgrKey + ";";
                    SqlCommand komut = new SqlCommand(query, baglanti);
                    komut.ExecuteNonQuery();
                    MessageBox.Show("Öğrenci Başarıyla Güncellendi");
                    baglanti.Close();
                    uyeler();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Anasayfa ana = new Anasayfa();
            ana.Show();
            this.Hide();
        }

        private void ResimYukleBtn_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            YonetimPb.ImageLocation = openFileDialog1.FileName;
            ResimTb.Text = openFileDialog1.FileName;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AdSoyadTb.Text = "";
            TelefonTb.Text = "";
            DogumTime.Text = "";
            AdresTb.Text = "";
            CinsiyetCb.Text = "";
            YonetimPb.ImageLocation = "";
        }

        private void yenileBtn_Click(object sender, EventArgs e)
        {
            uyeler();
        }
    }
}
