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
            frmSiparis frm = new frmSiparis();
            int uzunluk = btnMasa1.Text.Length;

            cGenel._buttonValue = btnMasa1.Text.Substring(uzunluk - 6, 6);
            cGenel._buttonName = btnMasa1.Name;

            //Loglama
            ch.PersonelId = cGenel._personelId;
            ch.Islem = cGenel._buttonValue.ToString() + " sipariş sayfasını açtı.";
            ch.Tarih = DateTime.Now;
            ch.PersonelActionSave(ch);

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
            frmSiparis frm = new frmSiparis();
            int uzunluk = btnMasa2.Text.Length;

            cGenel._buttonValue = btnMasa2.Text.Substring(uzunluk - 6, 6);
            cGenel._buttonName = btnMasa2.Name;

            //Loglama
            ch.PersonelId = cGenel._personelId;
            ch.Islem = cGenel._buttonValue.ToString() + " sipariş sayfasını açtı.";
            ch.Tarih = DateTime.Now;
            ch.PersonelActionSave(ch);

            this.Close();
            frm.ShowDialog();
        }

        private void btnMasa3_Click(object sender, EventArgs e)
        {
            frmSiparis frm = new frmSiparis();
            int uzunluk = btnMasa3.Text.Length;

            cGenel._buttonValue = btnMasa3.Text.Substring(uzunluk - 6, 6);
            cGenel._buttonName = btnMasa3.Name;

            //Loglama
            ch.PersonelId = cGenel._personelId;
            ch.Islem = cGenel._buttonValue.ToString() + " sipariş sayfasını açtı.";
            ch.Tarih = DateTime.Now;
            ch.PersonelActionSave(ch);

            this.Close();
            frm.ShowDialog();
        }

        private void btnMasa4_Click(object sender, EventArgs e)
        {
            frmSiparis frm = new frmSiparis();
            int uzunluk = btnMasa4.Text.Length;

            cGenel._buttonValue = btnMasa4.Text.Substring(uzunluk - 6, 6);
            cGenel._buttonName = btnMasa4.Name;

            //Loglama
            ch.PersonelId = cGenel._personelId;
            ch.Islem = cGenel._buttonValue.ToString() + " sipariş sayfasını açtı.";
            ch.Tarih = DateTime.Now;
            ch.PersonelActionSave(ch);

            this.Close();
            frm.ShowDialog();
        }

        private void btnMasa5_Click(object sender, EventArgs e)
        {
            frmSiparis frm = new frmSiparis();
            int uzunluk = btnMasa5.Text.Length;

            cGenel._buttonValue = btnMasa5.Text.Substring(uzunluk - 6, 6);
            cGenel._buttonName = btnMasa5.Name;

            //Loglama
            ch.PersonelId = cGenel._personelId;
            ch.Islem = cGenel._buttonValue.ToString() + " sipariş sayfasını açtı.";
            ch.Tarih = DateTime.Now;
            ch.PersonelActionSave(ch);

            this.Close();
            frm.ShowDialog();
        }

        private void btnMasa6_Click(object sender, EventArgs e)
        {
            frmSiparis frm = new frmSiparis();
            int uzunluk = btnMasa6.Text.Length;

            cGenel._buttonValue = btnMasa6.Text.Substring(uzunluk - 6, 6);
            cGenel._buttonName = btnMasa6.Name;

            //Loglama
            ch.PersonelId = cGenel._personelId;
            ch.Islem = cGenel._buttonValue.ToString() + " sipariş sayfasını açtı.";
            ch.Tarih = DateTime.Now;
            ch.PersonelActionSave(ch);

            this.Close();
            frm.ShowDialog();
        }

        private void btnMasa7_Click(object sender, EventArgs e)
        {
            frmSiparis frm = new frmSiparis();
            int uzunluk = btnMasa7.Text.Length;

            cGenel._buttonValue = btnMasa7.Text.Substring(uzunluk - 6, 6);
            cGenel._buttonName = btnMasa7.Name;

            //Loglama
            ch.PersonelId = cGenel._personelId;
            ch.Islem = cGenel._buttonValue.ToString() + " sipariş sayfasını açtı.";
            ch.Tarih = DateTime.Now;
            ch.PersonelActionSave(ch);

            this.Close();
            frm.ShowDialog();
        }

        private void btnMasa8_Click(object sender, EventArgs e)
        {
            frmSiparis frm = new frmSiparis();
            int uzunluk = btnMasa8.Text.Length;

            cGenel._buttonValue = btnMasa8.Text.Substring(uzunluk - 6, 6);
            cGenel._buttonName = btnMasa8.Name;

            //Loglama
            ch.PersonelId = cGenel._personelId;
            ch.Islem = cGenel._buttonValue.ToString() + " sipariş sayfasını açtı.";
            ch.Tarih = DateTime.Now;
            ch.PersonelActionSave(ch);

            this.Close();
            frm.ShowDialog();
        }

        private void btnMasa9_Click(object sender, EventArgs e)
        {
            frmSiparis frm = new frmSiparis();
            int uzunluk = btnMasa9.Text.Length;

            cGenel._buttonValue = btnMasa9.Text.Substring(uzunluk - 6, 6);
            cGenel._buttonName = btnMasa9.Name;

            //Loglama
            ch.PersonelId = cGenel._personelId;
            ch.Islem = cGenel._buttonValue.ToString() + " sipariş sayfasını açtı.";
            ch.Tarih = DateTime.Now;
            ch.PersonelActionSave(ch);

            this.Close();
            frm.ShowDialog();
        }

        private void frmMasalar_Load(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection(cGenel.conString);
            SqlCommand cmd = new SqlCommand("SELECT Durum,Id FROM [LahmacuncuApp].[dbo].[Masalar]", con);
            SqlDataReader dr = null;

            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                foreach (Control item in this.Controls)
                {
                    if (item is Button)
                    {


                        if (item.Name == "btnMasa" + dr["Id"].ToString() && dr["Durum"].ToString() == "1")
                        {
                            item.BackColor = Color.YellowGreen;
                            item.ForeColor = Color.Black;
                            toolTip1.SetToolTip(item, "Boş Masa");
                        }


                        else if (item.Name == "btnMasa" + dr["Id"].ToString() && dr["Durum"].ToString() == "2")
                        {
                            //Masa ne kadar süredir dolu hesaplanıyor.
                            cMasalar ms = new cMasalar();
                            DateTime dt1 = Convert.ToDateTime(ms.SessionSum(2));
                            DateTime dt2 = DateTime.Now;

                            string st1 = Convert.ToDateTime(ms.SessionSum(2)).ToShortTimeString();
                            string st2 = DateTime.Now.ToShortTimeString();

                            DateTime t1 = dt1.AddMinutes(DateTime.Parse(st1).TimeOfDay.TotalMinutes);
                            DateTime t2 = dt1.AddMinutes(DateTime.Parse(st2).TimeOfDay.TotalMinutes);

                            var fark = t2 - t1;

                            //Masa doluluk süresi tooltip'e basılıyor.
                            toolTip1.SetToolTip(item, string.Format("{0} {1}",                                
                                fark.Hours > 0 ? string.Format("{0} Saat", fark.Hours) : "",
                                fark.Minutes > 0 ? string.Format("{0} Dakikadır dolu.", fark.Minutes) : "").Trim());
                            item.BackColor = Color.Red;

                        }


                        else if (item.Name == "btnMasa" + dr["Id"].ToString() && dr["Durum"].ToString() == "3")
                        {
                            item.BackColor = Color.CadetBlue;
                            toolTip1.SetToolTip(item, "Açık Rezerve");
                        }


                        else if (item.Name == "btnMasa" + dr["Id"].ToString() && dr["Durum"].ToString() == "4")
                        {
                            item.BackColor = Color.DarkOrange;
                            item.ForeColor = Color.Black;
                            toolTip1.SetToolTip(item, "Rezerve Edilmiş.");
                        }
                    }
                }
            }
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }
    }
}
