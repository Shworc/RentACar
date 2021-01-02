using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class AutoBusiness
    {


        public List<Automobile> GetAllAutos()
        {
            return this.autoRepository.GetAllAutos();
        }

        public bool InsertAutos(Automobile a)
        {
            if (this.autoRepository.InsertAutos(a) > 0)
            {
                return true;
            }
            return false;
        }
    }
}
