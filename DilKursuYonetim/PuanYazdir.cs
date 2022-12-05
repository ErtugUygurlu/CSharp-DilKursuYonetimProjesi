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
    public partial class PuanYazdir : Form
    {
        public PuanYazdir()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-ORL2PMQ\SQLEXPRESS;Initial Catalog=kurs;Integrated Security=True");

        private void button5_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from PuanTbl where OgrenciId like '%" + FilterTb.Text + "%'", baglanti);
            SqlDataAdapter sda = new SqlDataAdapter(komut);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            PuanYazdirDgv.DataSource = ds.Tables[0];
            baglanti.Close();
        }
        private void Puanlar()
        {
            baglanti.Open();
            string query = "select * from PuanTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, baglanti);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            PuanYazdirDgv.DataSource = ds.Tables[0];
            baglanti.Close();
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Puanlar();
        }

        private void yenileBtn_Click(object sender, EventArgs e)
        {
            Puanlar();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Anasayfa ana = new Anasayfa();
            ana.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap map = new Bitmap(this.PuanYazdirDgv.Width, this.PuanYazdirDgv.Height);
            PuanYazdirDgv.DrawToBitmap(map, new Rectangle(0, 0, this.PuanYazdirDgv.Width, this.PuanYazdirDgv.Height));
            e.Graphics.DrawImage(map, 20, 150);
            e.Graphics.DrawString(label1.Text, new Font("Verdana", 20, FontStyle.Bold), Brushes.Black, new Point(300, 30));
            this.PuanYazdirDgv.Columns["PuanId"].Visible = false;
        }
    }
}
