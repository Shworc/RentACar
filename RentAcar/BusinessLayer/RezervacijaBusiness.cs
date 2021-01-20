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
            this.zakupacRepository = new ZakupacRepository();
            this.rezervacijaRepository = new RezervacijaRepository();
        }

        public List<Rezervacija> GetAllRezervations()
        {
            return this.rezervacijaRepository.GetAllRezervations();
        }

       /*public List<Rezervacija> GetRezervacijaById()
        {

            return List < Zakupac > this.GetAllRezervations().Where(r1 => r1.ZakupacID == r1.Id);
        }*/

        /*    public List<Rezervacija> GetRezervacijaById(String textBoxUsername)
        {
            
            //return this.GetRezervacijaById(textBoxUsername).Where(r => r.ZakupacID == zakupacRepository.r.ID));
        }*/
       
        public bool InsertRezervacija(Rezervacija r)
        {
            if (this.rezervacijaRepository.InsertRezervacija(r) > 0)
            {
                return true;
            }
            return false;
        }

        public bool UpdateRezervacija(Rezervacija r)
        {
            if (this.rezervacijaRepository.UpdateRezervacija(r) > 0)
            {
                return true;
            }
            return false;
        }

        public bool DeleteRezervacija(Rezervacija r)
        {
            if (this.rezervacijaRepository.DeleteRezervacija(r) > 0)
            {
                return true;
            }
            return false;
        }


        //kreirati fja da prikazuje listu rezervacija za trenutnog korisnika

        public List<Zakupac> GetAllZakupci()
        {
            return this.zakupacRepository.GetAllZakupci();
        }

        public bool InsertZakupac(Zakupac r)
        {
            if (this.zakupacRepository.InsertZakupac(r) > 0)
            {
                return true;
            }
            return false;
        }

        public bool UpdateZakupac(Zakupac r)
        {
            if (this.zakupacRepository.UpdateZakupac(r) > 0)
            {
                return true;
            }
            return false;
        }

        public bool DeleteZakupac(Zakupac r)
        {
            if (this.zakupacRepository.UpdateZakupac(r) > 0)
            {
                return true;
            }
            return false;
        }
    }
}
