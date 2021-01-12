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


        public List<Zakupac> GetAllZakupci()
        {
            return this.zakupacRepository.GetAllZakupci();
        }
        public ZakupacBusiness()
        {
            this.zakupacRepository = new ZakupacRepository();
        }
        public bool InsertZakupac(Zakupac r)
        {
            if (this.zakupacRepository.InsertZakupac(r) > 0)
            {
                return true;
            }
            return false;
        }
    }
}
