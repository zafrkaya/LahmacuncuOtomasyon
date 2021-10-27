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
    class cPersoneller
    {

        cGenel gnl = new cGenel();

        #region Fields
        private int _PersonelId;
        private int _PersonelGorevId;
        private string _PersonelAd;
        private string _PersonelSoyad;
        private string _PersonelParola;
        private string _PersonelKullaniciAdi;
        private bool _PersonelDurum;
        #endregion

        #region Properties
        public int PersonelId { get => _PersonelId; set => _PersonelId = value; }
        public int PersonelGorevId { get => _PersonelGorevId; set => _PersonelGorevId = value; }
        public string PersonelAd { get => _PersonelAd; set => _PersonelAd = value; }
        public string PersonelSoyad { get => _PersonelSoyad; set => _PersonelSoyad = value; }
        public string PersonelParola { get => _PersonelParola; set => _PersonelParola = value; }
        public string PersonelKullaniciAdi { get => _PersonelKullaniciAdi; set => _PersonelKullaniciAdi = value; }
        public bool PersonelDurum { get => _PersonelDurum; set => _PersonelDurum = value; } 
        #endregion

        public bool PersonelEntryControl(string password, int userId)
        {
            bool result = false;
            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("SELECT * FROM Personeller WHERE Id =@Id and Parola=@Password", con);
            cmd.Parameters.Add("@Id", SqlDbType.VarChar).Value = userId;
            cmd.Parameters.Add("Password", SqlDbType.VarChar).Value = password;
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                result = Convert.ToBoolean(cmd.ExecuteScalar());
            }
            catch (Exception ex)
            {
                string hata = ex.Message;
                throw;
            }

            return result;
        }
        public void GetPersonelInformationByName(ComboBox cb)
        {
            cb.Items.Clear();

            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("SELECT * FROM Personeller", con);

            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }

            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                cPersoneller p = new cPersoneller();
                p.PersonelId = Convert.ToInt32(dr["Id"]);
                p.PersonelGorevId = Convert.ToInt32(dr["GorevId"]);
                p.PersonelAd = Convert.ToString(dr["Ad"]);
                p.PersonelSoyad = Convert.ToString(dr["Soyad"]);
                p.PersonelParola = Convert.ToString(dr["Parola"]);
                p.PersonelKullaniciAdi = Convert.ToString(dr["KullaniciAdi"]);
                p.PersonelDurum = Convert.ToBoolean(dr["Durum"]);
                cb.Items.Add(p);
            }
            dr.Close();
            con.Close();



        }
        public override string ToString()
        {
            return PersonelAd + " " + PersonelSoyad;
        }
    }
}
