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

        public List<Automobile> GetAllAutos()
        {
            return this.autoRepository.GetAllAutos();
        }

        public bool InsertAutos(Automobile a)
        {
            if (this.autoRepository.InsertAutomobile(a) > 0)
            {
                return true;
            }
            return false;
        }

        public bool UpdateAutos(Automobile a)
        {
            if (this.autoRepository.UpdateAutomobile(a) > 0)
            {
                return true;
            }
            return false;
        }

        public bool DeleteAutos(Automobile a)
        {
            if (this.autoRepository.DeleteAutomobile(a) > 0)
            {
                return true;
            }
            return false;
        }
    }
}
