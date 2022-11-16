using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    internal class GoodType_BLL
    {
        private GoodType_DAL goodType_DAL = new GoodType_DAL();
        public List<GoodType_DTO> getGooodTypes()
        {
            return goodType_DAL.getGoodTypes();
        }
    }
}
