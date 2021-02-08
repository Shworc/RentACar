using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Models
{
    class Klijent
    {
        public int id { get; set; }
        public String Ime { get; set; }
        public String Prezime { get; set; }
        public int JMBG { get; set; }
        public String Adresa{ get; set; }
        public String MobilniBroj { get; set; }
        public String Grad { get; set; }

    }
}
