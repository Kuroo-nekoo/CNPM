using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class FoodAndBeverage
    {

        public string id { get; set; }
        public string name { get; set; }
        public float price { get; set; }

        public FoodAndBeverage(string id, string name, float price)
        {
            this.id = id;
            this.name = name;
            this.price = price;
        }
    }
}
