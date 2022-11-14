using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Good_BLL
    {
        DatabaseAccess databaseAccess = new DatabaseAccess();
        public void getGoods()
        {
            databaseAccess.getGoods();
        }
    }
}
