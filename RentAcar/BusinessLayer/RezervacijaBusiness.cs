using DataLayer;
using DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class RezervacijaBusiness
    {
        private readonly RezervacijaRepository rezervacijaRepository;
        private readonly ZakupacRepository zakupacRepository;

        public RezervacijaBusiness()
        {
            this.rezervacijaRepository = new RezervacijaRepository();
        }

        public List<Rezervacija> GetAllRezervations()
        {
            return this.rezervacijaRepository.GetAllRezervations();
        }

        public List<Rezervacija> GetRezervacijaById(int ZakupacID)
        {
            return this.GetAllRezervations().FirstOrDefault(r1 => r1.ZakupacID == r1.Id);
        }

        public bool InsertRezervacija(Rezervacija r)
        {
            if (this.rezervacijaRepository.InsertRezervacija(r) > 0)
            {
                return true;
            }
            return false;
        }

        //kreirati fja da prikazuje listu rezervacija za trenutnog korisnika
    }
}
