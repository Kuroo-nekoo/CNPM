using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Good_DTO
    {
        public int id { get; set; }
        public string name { get; set; }
        public GoodType_DTO type { get; set; }
        public int amount { get; set; }
        public double price { get; set; }
        public DateTime expiredDate { get; set; }
        public Good_DTO(int id, string name, GoodType_DTO type, int amount, double price, DateTime expiredDate)
        {
            this.id = id;
            this.name = name;
            this.type = type;
            this.amount = amount;
            this.price = price;
            this.expiredDate = expiredDate;
        }

        public Good_DTO (string name, GoodType_DTO type, int amount, double price, DateTime expiredDate)
        {
            this.name = name;
            this.type = type;
            this.amount = amount;
            this.price = price;
            this.expiredDate = expiredDate;
        }
    }
}
