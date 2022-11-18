using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class GoodType_BLL
    {
        private GoodType_DAL goodType_DAL; 
        public GoodType_BLL()
        {
            goodType_DAL = new GoodType_DAL();
        }
        public List<GoodType_DTO> getGoodTypes()
        {
            return goodType_DAL.getGoodTypes();
        }
    }
}
