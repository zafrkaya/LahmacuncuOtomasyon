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
    class cSiparis
    {
        cGenel gnl = new cGenel();
        private int _id;
        private int _adisyonId;
        private int _urunId;
        private int _adet;
        private int _masaId;

        #region Properties
        public int Id { get => _id; set => _id = value; }
        public int AdisyonId { get => _adisyonId; set => _adisyonId = value; }
        public int UrunId { get => _urunId; set => _urunId = value; }
        public int Adet { get => _adet; set => _adet = value; }
        public int MasaId { get => _masaId; set => _masaId = value; }
        #endregion

        //Siparişleri getir
        public void GetOrder(ListView lv, int adisyonId)
        {
            SqlConnection con = new SqlConnection(cGenel.conString);
            SqlCommand cmd = new SqlCommand("Select UrunAd,Fiyat,Satislar.Id,Satislar.UrunId,Satislar.Adet From Satislar Inner Join Urunler on Satislar.UrunId=Urunler.Id Where AdisyonId=@AdisyonId", con);
            SqlDataReader dr = null;
            cmd.Parameters.Add("@AdisyonId", SqlDbType.Int).Value = adisyonId;
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                dr = cmd.ExecuteReader();
                int sayac = 0;
                while (dr.Read())
                {
                    lv.Items.Add(dr["UrunAd"].ToString());
                    lv.Items[sayac].SubItems.Add(dr["Adet"].ToString());
                    lv.Items[sayac].SubItems.Add(dr["UrunId"].ToString());
                    lv.Items[sayac].SubItems.Add(Convert.ToString(Convert.ToDecimal(dr["Fiyat"]) * Convert.ToDecimal(dr["Adet"])));
                    lv.Items[sayac].SubItems.Add(dr["Id"].ToString());
                    sayac++;
                }
            }
            catch (SqlException ex)
            {
                string hata = ex.Message;
            }
        }

        public bool SetSaveOrder(cSiparis bilgiler)
        {
            bool result = false;
            SqlConnection con = new SqlConnection(cGenel.conString);
            SqlCommand cmd = new SqlCommand("INSERT INTO Satislar(AdisyonId,UrunId,Adet,MasaID) VALUES(@AdisyonId,@UrunId,@Adet,@MasaId)", con);
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                cmd.Parameters.Add("@AdisyonId", SqlDbType.Int).Value = bilgiler.AdisyonId;
                cmd.Parameters.Add("@UrunId", SqlDbType.Int).Value = bilgiler.UrunId;
                cmd.Parameters.Add("@Adet", SqlDbType.Int).Value = bilgiler.Adet;
                cmd.Parameters.Add("@MasaId", SqlDbType.Int).Value = bilgiler.MasaId;
                result = Convert.ToBoolean(cmd.ExecuteNonQuery());


            }
            catch (SqlException ex)
            {
                string hata = ex.Message;
            }
            finally
            {
                con.Dispose();
                con.Close();
            }

            return result;
        }

        public void DeleteOrder(int satisId)
        {
            SqlConnection con = new SqlConnection(cGenel.conString);
            SqlCommand cmd = new SqlCommand("Delete From Satislar Where Id=@SatisId", con);
            cmd.Parameters.Add("@SatisId", SqlDbType.Int).Value = satisId;

            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }

            cmd.ExecuteNonQuery();
            con.Dispose();
            con.Close();

        }
    }
}
