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
    public partial class frmGiris : Form
    {
        public frmGiris()
        {
            InitializeComponent();
        }

        cGenel gnl = new cGenel();
        private void btnGiris_Click(object sender, EventArgs e)
        {

        }

        private void btnGiris_Click_1(object sender, EventArgs e)
        {
            cPersoneller p = new cPersoneller();
            bool result = p.PersonelEntryControl(txtSifre.Text,gnl._personelId);

            if (result)
            {
                this.Hide();
                frmMenu menu = new frmMenu();
                menu.Show();
            }

        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmGiris_Load(object sender, EventArgs e)
        {
            cPersoneller p = new cPersoneller();
            p.GetPersonelInformationByName(cbKullanici);
        }
    }
}
