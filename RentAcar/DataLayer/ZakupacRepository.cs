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
                    z.Ime, z.Password);

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
                    z.Ime = sqlDataReader.GetString(1);
                    z.Password = sqlDataReader.GetString(2);
              
                    results.Add(z);
                }

                DBConnection.CloseConnection();

                return results;
            }



            public int InsertZakupac(Zakupac z)
            {
                var result = DBConnection.EditData(string.Format("INSERT INTO Zakupac VALUES ('{0}', '{1}')",
                        z.Ime, z.Password));
                DBConnection.CloseConnection();

                return result;
            }

        public int UpdateZakupac(Zakupac z)
        {
            var result = DBConnection.EditData(string.Format("UPDATE Zakupac SET Ime = '{0}', Password = '{1}')" + "WHERE ID={3}",
                    z.Ime, z.Password, z.ID));
            DBConnection.CloseConnection();

            return result;
        }

    }
}
