using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace DTO
{
    public class GoodType_DTO
    {
        public int id { get; set; }
        public string value { get; set; }
        public GoodType_DTO (int id, string value)
        {
            this.id = id;
            this.value = value;
        }
    }
}
