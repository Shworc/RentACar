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
        public List<Automobile> GetAllAutos()
        {
            List<Automobile> results = new List<Automobile>();
            SqlDataReader sqlDataReader = DBConnection.GetData("SELECT * FROM Automobil");

            while(sqlDataReader.Read())
            {
                Automobile a = new Automobile();
                a.ID = sqlDataReader.GetInt32(0);
                a.Marka = sqlDataReader.GetString(1);
                a.Naziv = sqlDataReader.GetString(2);

                results.Add(a);
            }
            DBConnection.CloseConnection();

            return results;
        }

        public int InsertAutomobile(Automobile a)
        {
            var result = DBConnection.EditData(string.Format("INSERT INTO Automobil VALUES ('{0}', '{1}')",
                    a.Marka, a.Naziv));
            DBConnection.CloseConnection();

            return result;
        }

        public int UpdateAutomobile(Automobile a)
        {
            var result = DBConnection.EditData(string.Format("UPDATE Automobil SET Marka ='{0}', Naziv ='{1}'" + "WHERE ID={2}",
                    a.Marka, a.Naziv, a.ID));
            DBConnection.CloseConnection();

            return result;
        }

        public int DeleteAutomobile(Automobile a)
        {
            var result = DBConnection.EditData(string.Format("DELETE FROM Automobil WHERE ID={0}",
                    a.ID));
            DBConnection.CloseConnection();

            return result;
        }

    }
}
