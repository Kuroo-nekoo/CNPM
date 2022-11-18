using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class FoodAndBeverageType_DTO
    {
        public int id { get; set; }
        public string value { get; set; }
        public List<FoodAndBeverage_DTO> items { get; set; }

        public FoodAndBeverageType_DTO(int id, string value, List<FoodAndBeverage_DTO> items)
        {
            this.id = id;
            this.value = value;
            this.items = items;
        }

        public FoodAndBeverageType_DTO(int id, string value)
        {
            this.id = id;
            this.value = value;
        }
    }
}
