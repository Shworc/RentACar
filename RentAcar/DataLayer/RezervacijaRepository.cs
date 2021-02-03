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
                r.KorisnikID = sqlDataReader.GetInt32(3);
                r.AutomobilID = sqlDataReader.GetInt32(4);

                results.Add(r);
            }

            DBConnection.CloseConnection();

            return results;
        }


        public List<Rezervacija> GetRezervacijaById(String textBoxUsername)
        {
            List<Rezervacija> results = new List<Rezervacija>();
            List<Korisnik> results1 = new List<Korisnik>();

            SqlDataReader sqlDataReader = DBConnection.GetData("SELECT Ime, Marka, Naziv, DatumOd, DatumDo FROM Rezervacija JOIN Korisnik ON Rezervacija.KorisnikID = Korisnik.Id ON Rezervacija.AutomobilID = Automobil.Id WHERE Korisnik.Ime = " + textBoxUsername.ToString());

            while (sqlDataReader.Read())
            {
                Rezervacija r = new Rezervacija();
                Korisnik r1 = new Korisnik();
                r.Id = sqlDataReader.GetInt32(0);
                r.DatumOd = sqlDataReader.GetDateTime(1);
                r.DatumDo = sqlDataReader.GetDateTime(2);
                r.KorisnikID = sqlDataReader.GetInt32(3);
                r.AutomobilID = sqlDataReader.GetInt32(4);
                r1.ID = sqlDataReader.GetInt32(5);
                r1.Korisnicko = sqlDataReader.GetString(6);
                r1.Sifra = sqlDataReader.GetString(7);

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
                    r.KorisnikID = sqlDataReader.GetInt32(3);
                    r.AutomobilID = sqlDataReader.GetInt32(4);

                    results.Add(r);
                }

                //DBConnection.CloseConnection();

                return results;
            }
        }
        */
           
            public int InsertRezervacija(Rezervacija r)
            {
                var result = DBConnection.EditData(string.Format("INSERT INTO Rezervacija VALUES ({0}, {1}, {2}, {3})",
                        r.DatumOd, r.DatumDo, r.KorisnikID, r.AutomobilID));
                DBConnection.CloseConnection();

                return result;
            }

        public int UpdateRezervacija(Rezervacija r)
        {
            var result = DBConnection.EditData(string.Format("UPDATE Rezervacija SET DatumOd = '{0}', DatumDo = '{1}', KorisnikID = {2}, AutomobilID = {3}" + "WHERE ID={4}",
                    r.DatumOd, r.DatumDo, r.KorisnikID, r.AutomobilID, r.Id));
            DBConnection.CloseConnection();

            return result;
        }

        public int DeleteRezervacija(Rezervacija r)
        {
            var result = DBConnection.EditData(string.Format("DELETE FROM Rezervacija WHERE ID={0}",
                    r.Id));
            DBConnection.CloseConnection();

            return result;
        }
    }
    }
