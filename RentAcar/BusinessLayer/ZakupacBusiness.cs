using DataLayer;
using DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class ZakupacBusiness
    {
        private readonly ZakupacRepository zakupacRepository;

        public ZakupacBusiness()
        {
            this.zakupacRepository = new ZakupacRepository();
        }

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

        public bool UpdateZakupac(Zakupac z)
        {
            if(this.zakupacRepository.UpdateZakupac(z) > 0)
            {
                return true;
            }
            return false;
        }

        public bool DeleteZakupac(Zakupac z)
        {
            if (this.zakupacRepository.DeleteZakupac(z) > 0)
            {
                return true;
            }
            return false;
        }
    }
}
