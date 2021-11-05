using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LahmacuncuOtomasyon
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        cPersonelHareketleri ch = new cPersonelHareketleri();
        private void btnMasa_Click(object sender, EventArgs e)
        {
            frmMasalar masa = new frmMasalar();
            masa.Show();
            this.Close();

            ch.PersonelId = cGenel._personelId;
            ch.Islem = "Masalar sayfasına giriş yaptı.";
            ch.Tarih = DateTime.Now;
            ch.PersonelActionSave(ch);
        }

        private void btnRezervasyon_Click(object sender, EventArgs e)
        {
            frmRezervasyon frmRez = new frmRezervasyon();
            this.Close();
            frmRez.Show();

            ch.PersonelId = cGenel._personelId;
            ch.Islem = "Rezervasyonlar sayfasına giriş yaptı.";
            ch.Tarih = DateTime.Now;
            ch.PersonelActionSave(ch);
        }

        private void btnPaketServis_Click(object sender, EventArgs e)
        {
            frmSiparis frmPaketServis = new frmSiparis();
            frmPaketServis.Show();
            this.Close();

            ch.PersonelId = cGenel._personelId;
            ch.Islem = "Paket Servis sayfasına giriş yaptı.";
            ch.Tarih = DateTime.Now;
            ch.PersonelActionSave(ch);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmMusteriler musteriler = new frmMusteriler();
            musteriler.Show();
            this.Close();

            ch.PersonelId = cGenel._personelId;
            ch.Islem = "Müşteriler sayfasına giriş yaptı.";
            ch.Tarih = DateTime.Now;
            ch.PersonelActionSave(ch);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmMutfak mutfak = new frmMutfak();
            mutfak.Show();
            this.Close();

            ch.PersonelId = cGenel._personelId;
            ch.Islem = "Mutfak sayfasına giriş yaptı.";
            ch.Tarih = DateTime.Now;
            ch.PersonelActionSave(ch);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmKasaIslemler frmKasaIslemler = new frmKasaIslemler();
            frmKasaIslemler.Show();
            this.Close();

            ch.PersonelId = cGenel._personelId;
            ch.Islem = "Kasalar sayfasına giriş yaptı.";
            ch.Tarih = DateTime.Now;
            ch.PersonelActionSave(ch);
        }

        private void btnRaporlar_Click(object sender, EventArgs e)
        {
            frmRaporlar frmRaporlar = new frmRaporlar();
            frmRaporlar.Show();
            this.Close();

            ch.PersonelId = cGenel._personelId;
            ch.Islem = "Raporlar sayfasına giriş yaptı.";
            ch.Tarih = DateTime.Now;
            ch.PersonelActionSave(ch);
        }

        private void btnAyarlar_Click(object sender, EventArgs e)
        {
            frmAyarlar frmAyarlar = new frmAyarlar();
            frmAyarlar.Show();
            this.Close();

            ch.PersonelId = cGenel._personelId;
            ch.Islem = "Ayarlar sayfasına giriş yaptı.";
            ch.Tarih = DateTime.Now;
            ch.PersonelActionSave(ch);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Çıkmak istediğinizden emin misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();

                ch.PersonelId = cGenel._personelId;
                ch.Islem = "Menü sayfası üzerinden çıkış yaptı.";
                ch.Tarih = DateTime.Now;
                ch.PersonelActionSave(ch);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
                       
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {
           
        }
    }
}
