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
        private readonly KorisnikRepository korisnikRepository;

        public RezervacijaBusiness()
        {
            this.korisnikRepository = new KorisnikRepository();
            this.rezervacijaRepository = new RezervacijaRepository();
        }

        public List<Rezervacija> GetAllRezervations()
        {
            return this.rezervacijaRepository.GetAllRezervations();
        }
       
       /*public List<Rezervacija> GetRezervacijaById()
        {

            return List < Korisnik > this.GetAllRezervations().Where(r1 => r1.KorisnikID == r1.Id);
        }*/

        /*    public List<Rezervacija> GetRezervacijaById(String textBoxUsername)
        {
            
            //return this.GetRezervacijaById(textBoxUsername).Where(r => r.KorisnikID == KorisnikRepository.r.ID));
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

        //public List<Korisnik> GetAllZakupci()
        //{
        //    return this.KorisnikRepository.GetAllZakupci();
        //}

        //public bool InsertKorisnik(Korisnik r)
        //{
        //    if (this.KorisnikRepository.InsertKorisnik(r) > 0)
        //    {
        //        return true;
        //    }
        //    return false;
        //}

        //public bool UpdateKorisnik(Korisnik r)
        //{
        //    if (this.KorisnikRepository.UpdateKorisnik(r) > 0)
        //    {
        //        return true;
        //    }
        //    return false;
        //}

        //public bool DeleteKorisnik(Korisnik r)
        //{
        //    if (this.KorisnikRepository.UpdateKorisnik(r) > 0)
        //    {
        //        return true;
        //    }
        //    return false;
        //}
    }
}
