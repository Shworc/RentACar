using DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    class AutoRepository
    {
        public List<Automobile> GetAllAutos()
        {
            List<Automobile> results = new List<Automobile>();
            SqlDataReader sqlDataReader = DBConnection.GetData("SELECT * FROM Atomobil");

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
    }
}
