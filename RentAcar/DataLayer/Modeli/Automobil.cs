using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Models
{
    public class Automobil
    {
        public int id { get; set; }
        public string Marka { get; set; }
        public string Model { get; set; }
        public string RegistarskiBroj { get; set; }
        public string BrojSasije { get; set; }
        public string Napomena { get; set; }
        public int Godiste { get; set; }
        public string Tip { get; set; }
        public string Boja { get; set; }
        public Boolean Stanje { get; set; }
    }
}
