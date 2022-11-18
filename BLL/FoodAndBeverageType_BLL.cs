using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class FoodAndBeverageType_BLL
    {
        public FoodAndBeverageType_DAL foodAndBeverageType_DAL = new FoodAndBeverageType_DAL();
        public List<FoodAndBeverageType_DTO> getFoodAndBeverageTypes()
        {
            return foodAndBeverageType_DAL.getFoodAndBeverageTypes();
        }
    }
}
