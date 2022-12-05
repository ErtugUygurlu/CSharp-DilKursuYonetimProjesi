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

namespace DilKursuYonetim
{
    public partial class PuanYonetim : Form
    {
        public PuanYonetim()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-ORL2PMQ\SQLEXPRESS;Initial Catalog=kurs;Integrated Security=True");
        int pid;
        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Puanlar()
        {
            baglanti.Open();
            string query = "select * from PuanTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, baglanti);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            PuanDgv.DataSource = ds.Tables[0];
            baglanti.Close();
        }

        private void PuanYonetim_Load(object sender, EventArgs e)
        {
            Puanlar();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (OgrenciIdTb.Text == "" || PuanTb.Text == "" || KursSecCb.Text == "" || AciklamaTb.Text == "")
            {
                MessageBox.Show("Silinecek Puanı Seçiniz");
            }
            else
            {
                try
                {
                    pid = Convert.ToInt32(PuanDgv.SelectedRows[0].Cells[0].Value.ToString());
                    baglanti.Open();
                    string query = "delete from PuanTbl where PuanId=" + pid + "";
                    SqlCommand komut = new SqlCommand(query, baglanti);
                    komut.ExecuteNonQuery();
                    MessageBox.Show("Puan Başarıyla Silindi");
                    baglanti.Close();
                    Puanlar();

                }
                catch (Exception Ex)
                {

                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void PuanDgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            pid = Convert.ToInt32(PuanDgv.SelectedRows[0].Cells[0].Value.ToString());
            OgrenciIdTb.Text = PuanDgv.SelectedRows[0].Cells[1].Value.ToString();
            PuanTb.Text = PuanDgv.SelectedRows[0].Cells[2].Value.ToString();
            KursSecCb.Text = PuanDgv.SelectedRows[0].Cells[3].Value.ToString();
            AciklamaTb.Text = PuanDgv.SelectedRows[0].Cells[4].Value.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (OgrenciIdTb.Text == "" || PuanTb.Text == "" || KursSecCb.Text == "" || AciklamaTb.Text == "")
            {
                MessageBox.Show("Eksik Bilgi");
            }
            else
            {
                try
                {
                    baglanti.Open();
                    string query = "update PuanTbl set OgrenciId=" + OgrenciIdTb.Text + ",Puan='" + PuanTb.Text + "',Kurs='" + KursSecCb.Text + "',Aciklama='" + AciklamaTb.Text + "'where PuanId=" + pid + ";";
                    SqlCommand komut = new SqlCommand(query, baglanti);
                    komut.ExecuteNonQuery();
                    MessageBox.Show("Puan Başarıyla Güncellendi");
                    baglanti.Close();
                    Puanlar();
                }
                catch (Exception Ex)
                {

                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            OgrenciIdTb.Text = "";
            PuanTb.Text = "";
            KursSecCb.Text = "";
            AciklamaTb.Text = "";
        }

        private void yenileBtn_Click(object sender, EventArgs e)
        {
            Puanlar();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from PuanTbl where OgrenciId like '%" + FilterTb.Text + "%'", baglanti);
            SqlDataAdapter sda = new SqlDataAdapter(komut);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            PuanDgv.DataSource = ds.Tables[0];
            baglanti.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Anasayfa ana = new Anasayfa();
            ana.Show();
            this.Hide();
        }
    }
}
