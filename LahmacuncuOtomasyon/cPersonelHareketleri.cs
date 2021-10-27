using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LahmacuncuOtomasyon
{
    class cPersonelHareketleri
    {
        #region Fields
        private int _id;
        private int _personelId;
        private string _islem;
        private DateTime _tarih;
        private bool _durum;
        #endregion

        #region Properties
        public int Id { get => _id; set => _id = value; }
        public int PersonelId { get => _personelId; set => _personelId = value; }
        public string Islem { get => _islem; set => _islem = value; }
        public DateTime Tarih { get => _tarih; set => _tarih = value; }
        public bool Durum { get => _durum; set => _durum = value; } 
        #endregion
        public bool PersonelActionSave(cPersonelHareketleri ph)
        {
            bool result = false;
            
            SqlConnection con = new SqlConnection(cGenel.conString);
            SqlCommand cmd = new SqlCommand("INSERT INTO [LahmacuncuApp].[dbo].[PersonelHareketleri] (PersonelId,Islem,Tarih) VALUES (@PersonelId,@Islem,@Tarih)",con);
            try
            {
                if (con.State ==ConnectionState.Closed)
                {
                    con.Open();
                    cmd.Parameters.Add("@PersonelId", SqlDbType.Int).Value = ph.PersonelId;
                    cmd.Parameters.Add("@Islem", SqlDbType.VarChar).Value = ph.Islem;
                    cmd.Parameters.Add("@Tarih", SqlDbType.DateTime).Value = ph.Tarih;
                    result = Convert.ToBoolean(cmd.ExecuteNonQuery());
                    
                }

                
            }
            catch (SqlException ex)
            {
                string hata = ex.Message;
                throw;
            }

            return result;
        }
    }
}
