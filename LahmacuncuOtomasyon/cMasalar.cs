using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LahmacuncuOtomasyon
{
    class cMasalar
    {
        #region Fields
        private int _id;
        private int _kapasite;
        private int _servisTuru;
        private int _durum;
        private int _onay;
        #endregion

        #region Properties
        public int Id { get => _id; set => _id = value; }
        public int Kapasite { get => _kapasite; set => _kapasite = value; }
        public int ServisTuru { get => _servisTuru; set => _servisTuru = value; }
        public int Durum { get => _durum; set => _durum = value; }
        public int Onay { get => _onay; set => _onay = value; }
        #endregion

        public string SessionSum(int state, string masaId)
        {
            string dt = "";
            SqlConnection con = new SqlConnection(cGenel.conString);
            SqlCommand cmd = new SqlCommand("SELECT Tarih,MasaId FROM Adisyon RIGHT JOIN Masalar ON Adisyon.MasaId=Masalar.Id WHERE Masalar.Durum=@durum AND Adisyon.Durum=0 AND Masalar.Id=@MasaId", con);
            SqlDataReader dr = null;
            cmd.Parameters.Add("@durum", SqlDbType.Int).Value = state;
            cmd.Parameters.Add("@MasaId", SqlDbType.Int).Value = Convert.ToInt32(masaId);

            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    dt = Convert.ToDateTime(dr["Tarih"]).ToString();
                }
            }
            catch (Exception ex)
            {
                string hata = ex.Message;
                throw;
            }

            finally
            {
                dr.Close();
                con.Dispose();
                con.Close();
            }
            return dt;
        }

        public int TableNoGetByNumber(string tableValue)
        {
            string aa = tableValue;
            int lenght = aa.Length;

            return Convert.ToInt32(aa.Substring(lenght - 1, 1));
        }

        public bool GetTableState(int buttonName, int state)
        {
            bool result = false;
            SqlConnection con = new SqlConnection(cGenel.conString);
            SqlCommand cmd = new SqlCommand("Select Durum From Masalar Where Id=@TableId and Durum=@state", con);
            cmd.Parameters.Add("@TableId", SqlDbType.Int).Value = buttonName;
            cmd.Parameters.Add("@state", SqlDbType.Int).Value = state;
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                result = Convert.ToBoolean(cmd.ExecuteScalar());
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

        public void ChangeTableState(string butonName, int state)
        {
            SqlConnection con = new SqlConnection(cGenel.conString);
            SqlCommand cmd = new SqlCommand("Update Masalar Set Durum=@Durum Where Id=@MasaNo", con);
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            string aa = butonName;
            int uzunluk = aa.Length;
            cmd.Parameters.Add("@Durum", SqlDbType.Int).Value = state;
            cmd.Parameters.Add("@MasaNo", SqlDbType.Int).Value = aa.Substring(uzunluk - 1, 1);
            cmd.ExecuteNonQuery();
            con.Dispose();
            con.Close();
        }


    }
}
