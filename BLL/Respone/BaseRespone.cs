using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Respone
{
    public class BaseRespone <T>
    {
        public int code { get; set; }
        public T value { get; set; }

        public BaseRespone (int code, T value)
        {
            this.code = code;
            this.value = value;
        }
    }
}
