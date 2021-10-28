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

        private void btnMasa_Click(object sender, EventArgs e)
        {
            frmMasalar masa = new frmMasalar();
            masa.Show();
            this.Close();
        }

        private void btnRezervasyon_Click(object sender, EventArgs e)
        {
            frmRezervasyon frmRez = new frmRezervasyon();
            this.Close();
            frmRez.Show();
        }

        private void btnPaketServis_Click(object sender, EventArgs e)
        {
            frmPaketServis frmPaketServis = new frmPaketServis();
            frmPaketServis.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmMusteriler musteriler = new frmMusteriler();
            musteriler.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmMutfak mutfak = new frmMutfak();
            mutfak.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmKasaIslemler frmKasaIslemler = new frmKasaIslemler();
            frmKasaIslemler.Show();
            this.Close();
        }

        private void btnRaporlar_Click(object sender, EventArgs e)
        {
            frmRaporlar frmRaporlar = new frmRaporlar();
            frmRaporlar.Show();
            this.Close();
        }

        private void btnAyarlar_Click(object sender, EventArgs e)
        {
            frmAyarlar frmAyarlar = new frmAyarlar();
            frmAyarlar.Show();
            this.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Çıkmak istediğinizden emin misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
