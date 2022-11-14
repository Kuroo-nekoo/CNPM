using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Good
    {
        public string id { get; set; }
        public string goodName { get; set; }
        public int amount { get; set; }
        public DateTime expiredDate { get; set; }
        public float price { get; set; }

        public string type { get; set; }

        public Good(string id, string goodName, string type, int amount, DateTime expiredDate, float price)
        {
            this.id = id;
            this.goodName = goodName;
            this.type = type;
            this.amount = amount;
            this.expiredDate = expiredDate;
            this.price = price;
        }
    }
}
