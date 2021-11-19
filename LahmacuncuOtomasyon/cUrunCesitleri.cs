using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LahmacuncuOtomasyon
{
    class cUrunCesitleri
    {
        private int _urunTurNo;
        private string _kategoriAd;
        private string _aciklama;

        public int UrunTurNo { get => _urunTurNo; set => _urunTurNo = value; }
        public string KategoriAd { get => _kategoriAd; set => _kategoriAd = value; }
        public string Aciklama { get => _aciklama; set => _aciklama = value; }

        public void GetProductTypes(ListView cesitler, Button btn)
        {
            cesitler.Items.Clear();
            SqlConnection con = new SqlConnection(cGenel.conString);
            SqlCommand cmd = new SqlCommand("Select UrunAdi,Fiyat,Urunler.Id From Kategoriler Inner Join urunler on Kategoriler.Id=Urunler.KategoriId WHERE Urunler.KategoriId=@KategoriId", con);
            string aa = btn.Name;
            int uzunluk = aa.Length;

            cmd.Parameters.Add("@KategoriId", SqlDbType.Int).Value = aa.Substring(uzunluk - 1, 1);
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlDataReader dr = cmd.ExecuteReader();
            int i = 0;
            while (dr.Read())
            {
                cesitler.Items.Add(dr["UrunAdi"].ToString());
                cesitler.Items[i].SubItems.Add(dr["Fiyat"].ToString());
                cesitler.Items[i].SubItems.Add(dr["Id"].ToString());
                i++;
            }
            dr.Close();
            con.Dispose();
            con.Close();
        }

    }
}
