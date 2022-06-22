using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Okul
{
    class yardim
    {
        public static SqlConnection baglan(string serverAdress,string dataBasaName)
        {
            string baglanticumle = @"Data Source = DESKTOP-C0V3RSM\SQLEXPRESS; Integrated Security = TRUE; Initial Catalog = Okul";
            SqlConnection baglanti = new SqlConnection(baglanticumle);

            return baglanti;
        }

        public static string crud(string gorev, string serverAdress,string dataBaseName)
        {
            string mesaj = "";
            SqlConnection kopru = baglan(serverAdress, dataBaseName);
            SqlCommand komut = new SqlCommand();
            komut.Connection = kopru;
            komut.CommandType = System.Data.CommandType.Text;
            komut.CommandText = gorev;

            try
            {
                kopru.Open();
                komut.ExecuteNonQuery();
                kopru.Close();
                mesaj = "Kayıt Tamam";
            }
            catch (Exception hata)
            {

                mesaj = hata.ToString();
            }
            return mesaj;
        }

        public static DataTable verioku(SqlConnection kopru, string sorgu)
        {
            DataTable tablolar = new DataTable();
            SqlCommand Sqlkomut = new SqlCommand();
            Sqlkomut.CommandText = sorgu;
            Sqlkomut.Connection = kopru;
            Sqlkomut.CommandType = CommandType.Text;
            SqlDataAdapter Adapter = new SqlDataAdapter(Sqlkomut);
            Adapter.Fill(tablolar);

            try
            {
                if (kopru.State == ConnectionState.Closed)
                {
                    kopru.Open();
                    Sqlkomut.ExecuteNonQuery();
                    kopru.Close();
                }
            }
            catch (Exception)
            {
            }
            return tablolar;
        }
    }
}
