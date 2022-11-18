using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class FoodAndBeverage_DTO
    {

        public int id { get; set; }
        public string name { get; set; }
        public double price { get; set; }
        public int amount { get; set; }
        public string size { get; set; }

        public FoodAndBeverage_DTO(int id, string name, double price, int amount, string size)
        {
            this.id = id;
            this.name = name;
            this.price = price;
            this.amount = amount;
            this.size = size;
        }
    }
}
