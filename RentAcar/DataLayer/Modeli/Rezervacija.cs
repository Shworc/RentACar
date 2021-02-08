using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Models
{
    public class Rezervacija
    {
        public int id { get; set; }
        public DateTime DatumOd { get; set; }
        public DateTime DatumDo { get; set; }
        public String Napomena{ get; set; }
        public int Korisnikid { get; set; }
        public int Automobilid { get; set; }
        public int Kljentid { get; set; }
        public Boolean Zavrsena { get; set; }

    }
}
