using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Category
    {
        public string id { get; set; }
        public string name { get; set; }
        public List<FoodAndBeverage> items { get; set; }

        public Category(string id, string name, List<FoodAndBeverage> items)
        {
            this.id = id;
            this.name = name;
            this.items = items;
        }
    }
}
