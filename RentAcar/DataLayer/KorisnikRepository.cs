using DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class KorisnikRepository
    {
       /* public int InsertKorisnik(Korisnik z)
        {
            using (SqlConnection sqlConnection = new SqlConnection(Constants.connectionString))
            {
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandText = string.Format("INSERT INTO Korisnik VALUES ('{0}','{1}')",
                    z.Korisnik, z.Sifra);

                sqlConnection.Open();

                return sqlCommand.ExecuteNonQuery();
            }
        }*/

            public List<Korisnik> GetAllKorisnici()
            {
                List<Korisnik> results = new List<Korisnik>();

                SqlDataReader sqlDataReader = DBConnection.GetData("SELECT * FROM Korisnici");

                while (sqlDataReader.Read())
                {
                    Korisnik k = new Korisnik();
                    k.ID = sqlDataReader.GetInt32(0);
                    k.Korisnicko = sqlDataReader.GetString(1);
                    k.Sifra = sqlDataReader.GetString(2);
              
                    results.Add(k);
                }

                DBConnection.CloseConnection();

                return results;
            }



            public int InsertKorisnik(Korisnik k)
            {
                var result = DBConnection.EditData(string.Format("INSERT INTO Korisnici VALUES ('{0}', '{1}')",
                        k.Korisnicko, k.Sifra));
                DBConnection.CloseConnection();

                return result;
            }

    }
}
