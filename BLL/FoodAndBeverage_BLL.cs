using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class FoodAndBeverage_BLL
    {
        private FoodAndBeverage_DAL foodAndBeverage_DAL = new FoodAndBeverage_DAL();
        public List<FoodAndBeverage_DTO> getFoodAndBeveragesByType(string type)
        {
            List<FoodAndBeverage_DTO> foodAndBeverages = foodAndBeverage_DAL.getFoodAndBeveragesByType(type);
            return foodAndBeverages;
        }
    }
}
