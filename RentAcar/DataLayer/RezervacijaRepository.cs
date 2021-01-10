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


        public List<Rezervacija> GetRezervacijaById(String textBoxUsername)
        {
            List<Rezervacija> results = new List<Rezervacija>();
            List<Zakupac> results1 = new List<Zakupac>();

            SqlDataReader sqlDataReader = DBConnection.GetData("SELECT Ime, Marka, Naziv, DatumOd, DatumDo FROM Rezervacija JOIN Zakupac ON Rezervacija.ZakupacID = Zakupac.Id ON Rezervacija.AutomobilID = Automobil.Id WHERE Zakupac.Ime = (['textBoxUsername]')");

            while (sqlDataReader.Read())
            {
                Rezervacija r = new Rezervacija();
                Zakupac r1 = new Zakupac();
                r.Id = sqlDataReader.GetInt32(0);
                r.DatumOd = sqlDataReader.GetDateTime(1);
                r.DatumDo = sqlDataReader.GetDateTime(2);
                r.ZakupacID = sqlDataReader.GetInt32(3);
                r.AutomobilID = sqlDataReader.GetInt32(4);
                r1.ID = sqlDataReader.GetInt32(5);
                r1.Ime = sqlDataReader.GetString(6);
                r1.Password = sqlDataReader.GetString(7);

                results.Add(r);
                results1.Add(r1);
            }

            DBConnection.CloseConnection();

            return results;
        }
        /*public List<Rezervacija> GetAllRezervations()
        {
            List<Rezervacija> results = new List<Rezervacija>();

            using (SqlConnection sqlConnection = new SqlConnection(Constants.connectionString)) // konekcija ka bazi
            {
                SqlCommand sqlCommand = new SqlCommand(); // sql obj
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandText = "SELECT * FROM Rezervacija";

                sqlConnection.Open(); // otvaranje konekcije

                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

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

                //DBConnection.CloseConnection();

                return results;
            }
        }*/

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
