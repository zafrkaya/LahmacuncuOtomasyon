using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LahmacuncuOtomasyon
{
    class cAdisyon
    {
        #region Fields
        private int _id;
        private int _servisTurNo;
        private decimal _tutar;
        private DateTime tarih;
        private int _personelId;
        private int _durum;
        private int _masaId; 
        #endregion

        #region Properties
        public int Id { get => _id; set => _id = value; }
        public int ServisTurNo { get => _servisTurNo; set => _servisTurNo = value; }
        public decimal Tutar { get => _tutar; set => _tutar = value; }
        public DateTime Tarih { get => tarih; set => tarih = value; }
        public int PersonelId { get => _personelId; set => _personelId = value; }
        public int Durum { get => _durum; set => _durum = value; }
        public int MasaId { get => _masaId; set => _masaId = value; } 
        #endregion

        public int GetAdditionByTableId(int masaId)
        {
            SqlConnection con = new SqlConnection(cGenel.conString);
            SqlCommand cmd = new SqlCommand("Select top 1 Id From Adisyon Where MasaId=@MasaId Order by Id Desc",con);
            cmd.Parameters.Add("@MasaId", SqlDbType.Int).Value = masaId;

            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                masaId = Convert.ToInt32(cmd.ExecuteScalar());
            }

            catch (SqlException ex)
            {
                string hata = ex.Message;
            }

            finally
            {
                con.Close();
                con.Dispose();
            }

            return masaId;

        }

        public bool SetNewAddition(cAdisyon bilgiler)
        {
            bool result = false;
            SqlConnection con = new SqlConnection(cGenel.conString);
            SqlCommand cmd = new SqlCommand("Insert Into Adisyon(ServisTurNo,Tarih,PersonelId,MasaId,Durum) VALUES (@ServisTurNo,@Tarih,@PersonelId,@MasaId,@Durum)", con);
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                cmd.Parameters.Add("@ServisTurNo", SqlDbType.Int).Value = bilgiler.ServisTurNo;
                cmd.Parameters.Add("@Tarih", SqlDbType.DateTime).Value = bilgiler.Tarih;
                cmd.Parameters.Add("@PersonelId", SqlDbType.Int).Value = bilgiler.PersonelId;
                cmd.Parameters.Add("@MasaId", SqlDbType.Int).Value = bilgiler.MasaId;
                cmd.Parameters.Add("@Durum", SqlDbType.Bit).Value = 0;
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
    }
}
