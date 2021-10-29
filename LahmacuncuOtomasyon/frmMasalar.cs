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
    public partial class frmMasalar : Form
    {
        public frmMasalar()
        {
            InitializeComponent();
        }

        cPersonelHareketleri ch = new cPersonelHareketleri();
        private void btnMasa1_Click(object sender, EventArgs e)
        {
            frmPaketServis frm = new frmPaketServis();
            int uzunluk = btnMasa1.Text.Length;

            cGenel._buttonValue = btnMasa1.Text.Substring(uzunluk - 6, 6);
            cGenel._buttonName = btnMasa1.Name;
            this.Close();
            frm.ShowDialog();

        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Çıkmak istediğinizden emin misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();

                ch.PersonelId = cGenel._personelId;
                ch.Islem = "Masalar sayfası üzerinden çıkış yaptı.";
                ch.Tarih = DateTime.Now;
                ch.PersonelActionSave(ch);
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            frmMenu frmMenu = new frmMenu();
            frmMenu.Show();
            this.Close();

            ch.PersonelId = cGenel._personelId;
            ch.Islem = "Masalar sayfasından ana menüye giriş yaptı.";
            ch.Tarih = DateTime.Now;
            ch.PersonelActionSave(ch);
        }

        private void btnMasa2_Click(object sender, EventArgs e)
        {
            frmPaketServis frm = new frmPaketServis();
            int uzunluk = btnMasa2.Text.Length;

            cGenel._buttonValue = btnMasa2.Text.Substring(uzunluk - 6, 6);
            cGenel._buttonName = btnMasa2.Name;
            this.Close();
            frm.ShowDialog();
        }

        private void btnMasa3_Click(object sender, EventArgs e)
        {
            frmPaketServis frm = new frmPaketServis();
            int uzunluk = btnMasa3.Text.Length;

            cGenel._buttonValue = btnMasa3.Text.Substring(uzunluk - 6, 6);
            cGenel._buttonName = btnMasa3.Name;
            this.Close();
            frm.ShowDialog();
        }

        private void btnMasa4_Click(object sender, EventArgs e)
        {
            frmPaketServis frm = new frmPaketServis();
            int uzunluk = btnMasa4.Text.Length;

            cGenel._buttonValue = btnMasa4.Text.Substring(uzunluk - 6, 6);
            cGenel._buttonName = btnMasa4.Name;
            this.Close();
            frm.ShowDialog();
        }

        private void btnMasa5_Click(object sender, EventArgs e)
        {
            frmPaketServis frm = new frmPaketServis();
            int uzunluk = btnMasa5.Text.Length;

            cGenel._buttonValue = btnMasa5.Text.Substring(uzunluk - 6, 6);
            cGenel._buttonName = btnMasa5.Name;
            this.Close();
            frm.ShowDialog();
        }

        private void btnMasa6_Click(object sender, EventArgs e)
        {
            frmPaketServis frm = new frmPaketServis();
            int uzunluk = btnMasa6.Text.Length;

            cGenel._buttonValue = btnMasa6.Text.Substring(uzunluk - 6, 6);
            cGenel._buttonName = btnMasa6.Name;
            this.Close();
            frm.ShowDialog();
        }

        private void btnMasa7_Click(object sender, EventArgs e)
        {
            frmPaketServis frm = new frmPaketServis();
            int uzunluk = btnMasa7.Text.Length;

            cGenel._buttonValue = btnMasa7.Text.Substring(uzunluk - 6, 6);
            cGenel._buttonName = btnMasa7.Name;
            this.Close();
            frm.ShowDialog();
        }

        private void btnMasa8_Click(object sender, EventArgs e)
        {
            frmPaketServis frm = new frmPaketServis();
            int uzunluk = btnMasa8.Text.Length;

            cGenel._buttonValue = btnMasa8.Text.Substring(uzunluk - 6, 6);
            cGenel._buttonName = btnMasa8.Name;
            this.Close();
            frm.ShowDialog();
        }

        private void btnMasa9_Click(object sender, EventArgs e)
        {
            frmPaketServis frm = new frmPaketServis();
            int uzunluk = btnMasa9.Text.Length;

            cGenel._buttonValue = btnMasa9.Text.Substring(uzunluk - 6, 6);
            cGenel._buttonName = btnMasa9.Name;
            this.Close();
            frm.ShowDialog();
        }

        private void frmMasalar_Load(object sender, EventArgs e)
        {
            
        }
    }
}
