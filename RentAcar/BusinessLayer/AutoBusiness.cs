using DataLayer;
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
        private readonly AutoRepository autoRepository;

        public AutoBusiness()
        {
            this.autoRepository = new AutoRepository();
        }

        public List<Automobil> GetAllAutos()
        {
            return this.autoRepository.GetAllAutos();
        }

        public bool InsertAutos(Automobil a)
        {
            if (this.autoRepository.InsertAutomobil(a) > 0)
            {
                return true;
            }
            return false;
        }

        public bool UpdateAutos(Automobil a)
        {
            if (this.autoRepository.UpdateAutomobil(a) > 0)
            {
                return true;
            }
            return false;
        }

        public bool DeleteAutos(Automobil a)
        {
            if (this.autoRepository.DeleteAutomobil(a) > 0)
            {
                return true;
            }
            return false;
        }
    }
}
