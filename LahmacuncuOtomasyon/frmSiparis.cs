using System;
using System.Collections;
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
    public partial class frmSiparis : Form
    {
        public frmSiparis()
        {
            InitializeComponent();
        }

        cPersonelHareketleri ch = new cPersonelHareketleri();
        private void button10_Click(object sender, EventArgs e)
        {
            frmMasalar masalar = new frmMasalar();
            masalar.Show();
            this.Hide();
        }
        int additionId = 0;
        int tableId = 0;
        private void frmSiparis_Load(object sender, EventArgs e)
        {

            lblMasaNo.Text = cGenel._buttonValue;

            cMasalar masa = new cMasalar();
            tableId = masa.TableNoGetByNumber(cGenel._buttonName);
            if (masa.GetTableState(tableId, 2) == true || masa.GetTableState(tableId, 4) == true)
            {
                cAdisyon ad = new cAdisyon();
                additionId = ad.GetAdditionByTableId(tableId);
                cSiparis orders = new cSiparis();
                orders.GetOrder(lvSiparisler, additionId);

            }

            btn1.Click += new EventHandler(Islem);
            btn2.Click += new EventHandler(Islem);
            btn3.Click += new EventHandler(Islem);
            btn4.Click += new EventHandler(Islem);
            btn5.Click += new EventHandler(Islem);
            btn6.Click += new EventHandler(Islem);
            btn7.Click += new EventHandler(Islem);
            btn8.Click += new EventHandler(Islem);
            btn9.Click += new EventHandler(Islem);
            btn0.Click += new EventHandler(Islem);
        }

        //Hesap İşlemi
        void Islem(Object sender, EventArgs e)
        {
            Button btn = sender as Button;

            switch (btn.Name)
            {
                case "btn1":
                    txtAdet.Text += (1).ToString();
                    break;
                case "btn2":
                    txtAdet.Text += (2).ToString();
                    break;
                case "btn3":
                    txtAdet.Text += (3).ToString();
                    break;
                case "btn4":
                    txtAdet.Text += (4).ToString();
                    break;
                case "btn5":
                    txtAdet.Text += (5).ToString();
                    break;
                case "btn6":
                    txtAdet.Text += (6).ToString();
                    break;
                case "btn7":
                    txtAdet.Text += (7).ToString();
                    break;
                case "btn8":
                    txtAdet.Text += (8).ToString();
                    break;
                case "btn9":
                    txtAdet.Text += (9).ToString();
                    break;
                case "btn0":
                    txtAdet.Text += (0).ToString();
                    break;
                default:
                    MessageBox.Show("Lütfen sayı girin");
                    break;
            }

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtAdet.Clear();
        }

        cUrunCesitleri uc = new cUrunCesitleri();

        private void btnAnaYemek3_Click(object sender, EventArgs e)
        {
            uc.GetProductTypes(lvMenu, btnAnaYemek3);
        }

        private void btnIcecekler8_Click(object sender, EventArgs e)
        {
            uc.GetProductTypes(lvMenu, btnIcecekler8);
        }

        private void btnTatlilar7_Click(object sender, EventArgs e)
        {
            uc.GetProductTypes(lvMenu, btnTatlilar7);
        }

        private void btnSalata6_Click(object sender, EventArgs e)
        {
            uc.GetProductTypes(lvMenu, btnSalata6);
        }

        private void btnFastFood5_Click(object sender, EventArgs e)
        {
            uc.GetProductTypes(lvMenu, btnFastFood5);
        }

        private void btnCorbalar1_Click(object sender, EventArgs e)
        {
            uc.GetProductTypes(lvMenu, btnCorbalar1);
        }

        private void btnMakarnalar4_Click(object sender, EventArgs e)
        {
            uc.GetProductTypes(lvMenu, btnMakarnalar4);
        }

        private void btnAraSicak2_Click(object sender, EventArgs e)
        {
            uc.GetProductTypes(lvMenu, btnAraSicak2);
        }

        int sayac = 0;
        int sayac2 = 0;
        private void lvMenu_DoubleClick(object sender, EventArgs e)
        {
            if (txtAdet.Text == "")
            {
                txtAdet.Text = "1";
            }

            if (lvMenu.Items.Count > 0)
            {
                sayac = lvSiparisler.Items.Count;
                lvSiparisler.Items.Add(lvMenu.SelectedItems[0].Text);
                lvSiparisler.Items[sayac].SubItems.Add(txtAdet.Text);
                lvSiparisler.Items[sayac].SubItems.Add(lvMenu.SelectedItems[0].SubItems[2].Text);
                lvSiparisler.Items[sayac].SubItems.Add((Convert.ToDecimal(lvMenu.SelectedItems[0].SubItems[1].Text) *
                    Convert.ToDecimal(txtAdet.Text)).ToString());
                lvSiparisler.Items[sayac].SubItems.Add("0");

                sayac2 = lvYeniEklenenler.Items.Count;

                lvYeniEklenenler.Items.Add(additionId.ToString());
                lvYeniEklenenler.Items[sayac2].SubItems.Add(lvMenu.SelectedItems[0].SubItems[2].Text);
                lvYeniEklenenler.Items[sayac2].SubItems.Add(txtAdet.Text);                
                lvYeniEklenenler.Items[sayac2].SubItems.Add(tableId.ToString());
                lvYeniEklenenler.Items[sayac2].SubItems.Add(sayac2.ToString());

                sayac2++;
                txtAdet.Text = "";


            }
        }

        ArrayList silinenler = new ArrayList();
        private void btnSiparis_Click(object sender, EventArgs e)
        {
            /**
             * 1- Masa boş
             * 2- Masa dolu
             * 3- Masa rezerve
             * 4- Müşteri gelmiş rezerve
             */

            cMasalar masa = new cMasalar();
            cAdisyon newAddition = new cAdisyon();
            cSiparis saveOrder = new cSiparis();
            frmMasalar frmMasa = new frmMasalar();
            
            bool sonuc = false;
            if (masa.GetTableState(tableId,1) == true)
            {
                newAddition.ServisTurNo = 1;
                newAddition.PersonelId = 1;
                newAddition.MasaId = tableId;
                newAddition.Tarih = DateTime.Now;
                sonuc = newAddition.SetNewAddition(newAddition);
                masa.ChangeTableState(cGenel._buttonName, 2);


                if (lvSiparisler.Items.Count>0)
                {
                    for (int i = 0; i < lvSiparisler.Items.Count; i++)
                    {
                        saveOrder.MasaId = tableId;
                        saveOrder.UrunId = Convert.ToInt32(lvSiparisler.Items[i].SubItems[2].Text);
                        saveOrder.AdisyonId = newAddition.GetAdditionByTableId(tableId);
                        saveOrder.Adet = Convert.ToInt32(lvSiparisler.Items[i].SubItems[1].Text);
                        saveOrder.SetSaveOrder(saveOrder);
                    }
                    this.Close();
                    frmMasa.Show();
                }

                else if (masa.GetTableState(tableId,2) == true)
                {
                    if (lvYeniEklenenler.Items.Count > 0)
                    {
                        for (int i = 0; i < lvYeniEklenenler.Items.Count; i++)
                        {
                            saveOrder.MasaId = tableId;
                            saveOrder.UrunId = Convert.ToInt32(lvYeniEklenenler.Items[i].SubItems[1].Text);
                            saveOrder.AdisyonId = newAddition.GetAdditionByTableId(tableId);
                            saveOrder.Adet = Convert.ToInt32(lvYeniEklenenler.Items[i].SubItems[2].Text);
                            saveOrder.SetSaveOrder(saveOrder);
                        }
                    }
                }
            }
        }

        private void lvSiparisler_DoubleClick(object sender, EventArgs e)
        {
            if (lvSiparisler.Items.Count > 0)
            {
                if (lvSiparisler.SelectedItems[0].SubItems[4].Text != "0")
                {
                    cSiparis saveOrder = new cSiparis();
                    saveOrder.DeleteOrder(Convert.ToInt32(lvSiparisler.Items[0].SubItems[4].Text));
                }

                else
                {
                    for (int i = 0; i < lvYeniEklenenler.Items.Count; i++)
                    {
                        if (lvYeniEklenenler.Items[i].SubItems[4].Text == lvSiparisler.SelectedItems[0].SubItems[5].Text)
                        {
                            lvYeniEklenenler.Items.RemoveAt(i);
                        }
                    }
                }
                lvSiparisler.Items.RemoveAt(lvSiparisler.SelectedItems[0].Index);
            }
        }
    }
}
