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

        public string SessionSum(int state)
        {
            string dt = "";
            SqlConnection con = new SqlConnection(cGenel.conString);
            SqlCommand cmd = new SqlCommand("SELECT Tarih,MasaId FROM Adisyon RIGHT JOIN Masalar ON Adisyon.MasaId=Masalar.Id WHERE Masalar.Durum=@durum AND Adisyon.Durum=0", con);
            SqlDataReader dr = null;
            cmd.Parameters.Add("@durum", SqlDbType.Int).Value = state;

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




    }
}
