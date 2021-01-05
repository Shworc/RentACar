using DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class RezervacijaRepository
    {
        public List<Rezervacija> GetAllRezervations()
        {
            List<Rezervacija> results = new List<Rezervacija>();

            SqlDataReader sqlDataReader = DBConnection.GetData("SELECT * FROM Rezervacija");

            while (sqlDataReader.Read())
            {
                Rezervacija r = new Rezervacija();
                r.Id = sqlDataReader.GetInt32(0);
                r.DatumOd = sqlDataReader.GetDateTime(1);
                r.DatumDo = sqlDataReader.GetDateTime(2);
                r.ZakupacID = sqlDataReader.GetInt32(3);
                r.AutomobilID = sqlDataReader.GetInt32(4);

                results.Add(r);
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

        public int InsertZakupac(Zakupac z)
        {
            var result = DBConnection.EditData(string.Format("INSERT INTO Zakupac VALUES ('{0}', '{1}')",
                    z.Ime, z.Password));
            DBConnection.CloseConnection();

            return result;
        }

        public int InsertRezervacija(Rezervacija r)
        {
            var result = DBConnection.EditData(string.Format("INSERT INTO Rezervacija VALUES ('{0}', '{1}', {2}, {3})",
                    r.DatumOd, r.DatumDo, r.ZakupacID, r.AutomobilID));
            DBConnection.CloseConnection();

            return result;
        }
    }
}
