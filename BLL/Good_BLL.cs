using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace BLL
{
    public class Good_BLL
    {
        Good_DAL good_DAL = new Good_DAL();
        public List<Good> getGoods()
        {
            return good_DAL.getGoods();
        }

        public void deleteGood(string id)
        {
            good_DAL.deleteGood(id);
        }
    }
}
