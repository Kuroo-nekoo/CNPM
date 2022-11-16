using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Respone
{
    public class AddGoodReponse <T> : BaseRespone <T>
    {
        public AddGoodReponse(int code, T value) : base(code, value)
        { 
        }
    }
}
