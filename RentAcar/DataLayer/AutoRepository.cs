using DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class AutoRepository
    {
        public List<Automobil> GetAllAutos()
        {
            List<Automobil> results = new List<Automobil>();
            SqlDataReader sqlDataReader = DBConnection.GetData("SELECT * FROM Automobil");

            while(sqlDataReader.Read())
            {
                Automobil a = new Automobil();
                a.id = sqlDataReader.GetInt32(0);
                a.Marka = sqlDataReader.GetString(1);
                a.Model = sqlDataReader.GetString(2);

                results.Add(a);
            }
            DBConnection.CloseConnection();

            return results;
        }

        public int InsertAutomobil(Automobil a)
        {
            var result = DBConnection.EditData(string.Format("INSERT INTO Automobil VALUES ('{0}', '{1}')",
                    a.Marka, a.Model));
            DBConnection.CloseConnection();

            return result;
        }

        public int UpdateAutomobil(Automobil a)
        {
            var result = DBConnection.EditData(string.Format("UPDATE Automobil SET Marka ='{0}', Naziv ='{1}'" + "WHERE id={2}",
                    a.Marka, a.Model, a.id));
            DBConnection.CloseConnection();

            return result;
        }

        public int DeleteAutomobil(Automobil a)
        {
            var result = DBConnection.EditData(string.Format("DELETE FROM Automobil WHERE id={0}",
                    a.id));
            DBConnection.CloseConnection();

            return result;
        }

    }
}
