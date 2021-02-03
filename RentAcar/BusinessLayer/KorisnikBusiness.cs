using DataLayer;
using DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class KorisnikBusiness
    {
        private readonly KorisnikRepository korisnikRepository;

        public KorisnikBusiness()
        {
            this.korisnikRepository = new KorisnikRepository();
        }

        public List<Korisnik> GetAllZakupci()
        {
            return this.korisnikRepository.GetAllKorisnici();
        }

        //public bool InsertKorisnik(Korisnik r)
        //{
        //    if (this.KorisnikRepository.InsertKorisnik(r) > 0)
        //    {
        //        return true;
        //    }
        //    return false;
        //}

        //public bool UpdateKorisnik(Korisnik z)
        //{
        //    if(this.KorisnikRepository.UpdateKorisnik(z) > 0)
        //    {
        //        return true;
        //    }
        //    return false;
        //}

        //public bool DeleteKorisnik(Korisnik z)
        //{
        //    if (this.KorisnikRepository.DeleteKorisnik(z) > 0)
        //    {
        //        return true;
        //    }
        //    return false;
        //}
    }
}
