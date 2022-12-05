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
    public partial class KayitYonetim : Form
    {
        public KayitYonetim()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-ORL2PMQ\SQLEXPRESS;Initial Catalog=kurs;Integrated Security=True");
        int KursKey;

        private void uyeler()
        {
            baglanti.Open();
            string query = "select * from KursTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, baglanti);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            KYonetimDgv.DataSource = ds.Tables[0];
            baglanti.Close();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (AdTb.Text == "" || SaatTb.Text == "" || AciklamaTb.Text == "")
            {
                MessageBox.Show("Silinecek Kursu Seçiniz");
            }
            else
            {
                KursKey = Convert.ToInt32(KYonetimDgv.SelectedRows[0].Cells[0].Value.ToString());
                try
                {
                    baglanti.Open();
                    string query = "delete from KursTbl where KursId=" + KursKey + "";
                    SqlCommand komut = new SqlCommand(query, baglanti);
                    komut.ExecuteNonQuery();
                    MessageBox.Show("Kurs Başarıyla Eklendi");
                    baglanti.Close();
                    uyeler();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AdTb.Text = "";
            SaatTb.Text = "";
            AciklamaTb.Text = "";
        }

        private void KYonetimDgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void KYonetimDgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            KursKey = Convert.ToInt32(KYonetimDgv.SelectedRows[0].Cells[0].Value.ToString());
            AdTb.Text = KYonetimDgv.SelectedRows[0].Cells[1].Value.ToString();
            SaatTb.Text = KYonetimDgv.SelectedRows[0].Cells[2].Value.ToString();
            AciklamaTb.Text = KYonetimDgv.SelectedRows[0].Cells[3].Value.ToString();
        }

        private void KayitYonetim_Load(object sender, EventArgs e)
        {
            uyeler();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (AdTb.Text == "" || SaatTb.Text == "" || AciklamaTb.Text == "")
            {
                MessageBox.Show("Eksik Bilgi");
            }
            else
            {
                try
                {
                    baglanti.Open();
                    string query = "update KursTbl set KursAdi='" + AdTb.Text + "',KursSaat='" + SaatTb.Text + "',Aciklama='" + AciklamaTb.Text + "'where KursId=" + KursKey + ";";
                    SqlCommand komut = new SqlCommand(query, baglanti);
                    komut.ExecuteNonQuery();
                    MessageBox.Show("Kurs Başarıyla Güncellendi");
                    baglanti.Close();
                    uyeler();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);

                    throw;
                }
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from KursTbl where KursAdi like '%" + FilterTb.Text + "%'", baglanti);
            SqlDataAdapter sda = new SqlDataAdapter(komut);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            KYonetimDgv.DataSource = ds.Tables[0];
            baglanti.Close();
        }

        private void yenileBtn_Click(object sender, EventArgs e)
        {
            uyeler();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Anasayfa ana = new Anasayfa();
            ana.Show();
            this.Hide();
        }
    }
}
