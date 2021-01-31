using DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class ZakupacRepository
    {
       /* public int InsertZakupac(Zakupac z)
        {
            using (SqlConnection sqlConnection = new SqlConnection(Constants.connectionString))
            {
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandText = string.Format("INSERT INTO Zakupac VALUES ('{0}','{1}')",
                    z.Korisnik, z.Sifra);

                sqlConnection.Open();

                return sqlCommand.ExecuteNonQuery();
            }
        }*/

            public List<Zakupac> GetAllZakupci()
            {
                List<Zakupac> results = new List<Zakupac>();

                SqlDataReader sqlDataReader = DBConnection.GetData("SELECT * FROM Zakupac");

                while (sqlDataReader.Read())
                {
                    Zakupac z = new Zakupac();
                    z.ID = sqlDataReader.GetInt32(0);
                    z.Korisnik = sqlDataReader.GetString(1);
                    z.Sifra = sqlDataReader.GetString(2);
              
                    results.Add(z);
                }

                DBConnection.CloseConnection();

                return results;
            }



            public int InsertZakupac(Zakupac z)
            {
                var result = DBConnection.EditData(string.Format("INSERT INTO Zakupac VALUES ('{0}', '{1}')",
                        z.Korisnik, z.Sifra));
                DBConnection.CloseConnection();

                return result;
            }

        public int UpdateZakupac(Zakupac z)
        {
            var result = DBConnection.EditData(string.Format("UPDATE Zakupac SET Korisnik ='{0}', Sifra ='{1}'" + "WHERE ID={2}", 
                    z.Korisnik, z.Sifra, z.ID));
            DBConnection.CloseConnection();

            return result;
        }

        public int DeleteZakupac(Zakupac z)
        {
            var result = DBConnection.EditData(string.Format("DELETE FROM Zakupac WHERE ID={0}",
                    z.ID));
            DBConnection.CloseConnection();

            return result;
        }

    }
}
