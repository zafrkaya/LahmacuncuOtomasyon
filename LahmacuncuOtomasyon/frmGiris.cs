using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace LahmacuncuOtomasyon
{
    public partial class frmGiris : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
            (
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nWeightEllipse
            );
        public frmGiris()
        {
            InitializeComponent();
            this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 40, 40));
        }

        cGenel gnl = new cGenel();
        private void btnGiris_Click(object sender, EventArgs e)
        {

        }

        private void btnGiris_Click_1(object sender, EventArgs e)
        {
            cPersoneller p = new cPersoneller();
            bool result = p.PersonelEntryControl(txtSifre.Text,cGenel._personelId);
            cPersonelHareketleri ch = new cPersonelHareketleri();
            if (result)
            {
                
                ch.PersonelId = cGenel._personelId;
                ch.Islem = "Giriş yaptı";
                ch.Tarih = DateTime.Now;
                ch.PersonelActionSave(ch);

                this.Hide();
                frmMenu menu = new frmMenu();
                menu.Show();
            }
            else
            {
                ch.PersonelId = cGenel._personelId;
                ch.Islem = "Şifreyi hatalı girdi.";
                ch.Tarih = DateTime.Now;
                ch.PersonelActionSave(ch);
                MessageBox.Show("Hatalı şifre!", "Uyarı",MessageBoxButtons.OK ,MessageBoxIcon.Warning);
            }

        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Çıkmak istediğinizden emin misiniz?","Uyarı",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
            {
                Application.Exit();
            }
            
        }

        private void frmGiris_Load(object sender, EventArgs e)
        {
            cPersoneller p = new cPersoneller();
            p.GetPersonelInformationByName(cbKullanici);
            cbKullanici.SelectedIndex = 0;

        }

        private void cbKullanici_SelectedIndexChanged(object sender, EventArgs e)
        {
            cPersoneller p = (cPersoneller)cbKullanici.SelectedItem;
            cGenel._personelId = p.PersonelId;
            cGenel._gorevId = p.PersonelGorevId;
            
        }
    }
}
