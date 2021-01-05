using DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class AutoBusiness
    {
        private readonly RezervacijaRepository rezervacijaRepository;

        public List<Automobile> GetAllAutos()
        {
            return this.rezervacijaRepository.GetAllRezervations();
        }

        public bool InsertAutos(Automobile a)
        {
            if (this.rezervacijaRepository.InsertAutomobile(a) > 0)
            {
                return true;
            }
            return false;
        }
    }
}
