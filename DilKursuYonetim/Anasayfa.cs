using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DilKursuYonetim
{
    public partial class Anasayfa : Form
    {
        public Anasayfa()
        {
            InitializeComponent();
            panelDesing();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void panelDesing()
        {
            panel_ogrenciMenu.Visible = false;
            panel_kursmenu.Visible = false;
            panel_puanmenu.Visible = false;
        }
        private void HideMenu()
        {
            if (panel_ogrenciMenu.Visible == true)
            {
                panel_ogrenciMenu.Visible = false;

            }
            if (panel_kursmenu.Visible == true)
            {
                panel_kursmenu.Visible = false;
            }
            if (panel_puanmenu.Visible == true)
            {
                panel_puanmenu.Visible = false;
            }

        }
        private void ShowMenu(Panel menu)
        {
            if (menu.Visible == false)
            {
                HideMenu();
                menu.Visible = true;
            }
            else
            {
                menu.Visible = false;
            }
        }

        private void button_ogrenci_Click(object sender, EventArgs e)
        {
            ShowMenu(panel_ogrenciMenu);
        }

        private void button_ogrencikayit_Click(object sender, EventArgs e)
        {
            HideMenu();
            kayitt kyt = new kayitt();
            kyt.Show();
            this.Hide();
        }

        private void button_ogrenciyonetim_Click(object sender, EventArgs e)
        {
            HideMenu();
            OgrenciYonetim ogry = new OgrenciYonetim();
            ogry.Show();
            this.Hide();

        }

        private void button_ogrenciicerik_Click(object sender, EventArgs e)
        {
            HideMenu();
        }

        private void button_ogrenciyazdir_Click(object sender, EventArgs e)
        {
            HideMenu();
            OgrenciYazdir yzd = new OgrenciYazdir();
            yzd.Show();
            this.Hide();
        }

        private void button_kurs_Click(object sender, EventArgs e)
        {
            ShowMenu(panel_kursmenu);
        }

        private void button_kurskayit_Click(object sender, EventArgs e)
        {
            HideMenu();
            YeniKurs yeni = new YeniKurs();
            yeni.Show();
            this.Hide();
        }

        private void button_kursyonetim_Click(object sender, EventArgs e)
        {
            HideMenu();
            KayitYonetim kyt = new KayitYonetim();
            kyt.Show();
            this.Hide();
        }

        private void button_kursyazdir_Click(object sender, EventArgs e)
        {
            HideMenu();
            KursYazdir kyzdr = new KursYazdir();
            kyzdr.Show();
            this.Hide();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            ShowMenu(panel_puanmenu);
        }

        private void button_puanlama_Click(object sender, EventArgs e)
        {
            HideMenu();
            YeniPuan yni = new YeniPuan();
            yni.Show();
            this.Hide();
        }

        private void button_puanyonetim_Click(object sender, EventArgs e)
        {
            HideMenu();
            PuanYonetim pyon = new PuanYonetim();
            pyon.Show();
            this.Hide();
        }

        private void button_puanyazdir_Click(object sender, EventArgs e)
        {
            HideMenu();
            PuanYazdir pyaz = new PuanYazdir();
            pyaz.Show();
            this.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button_cıkıs_Click(object sender, EventArgs e)
        {
            login log = new login();
            log.Show();
            this.Hide();
        }
    }
}
