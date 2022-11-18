using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using BLL.Respone;

namespace BLL
{
    public class Good_BLL
    {
        Good_DAL good_DAL;

        public Good_BLL ()
        {
            good_DAL = new Good_DAL();
        }
        public List<Good_DTO> getGoods()
        {
            return good_DAL.getGoods();
        }

        public void deleteGood(string id)
        {
            good_DAL.deleteGood(id);
        }

        public List<Good_DTO> filterGood(string filteredType)
        {
            return good_DAL.filterGood(filteredType);
        }

        public AddGoodReponse<String> addGood(Good_DTO good)
        {
            if (good.name == "")
            {
                return new AddGoodReponse<String>(0, "Tên hàng không được bỏ trống");    
            } 
            else if (good.amount < 0) 
            {
                return new AddGoodReponse<String>(0, "Số lượng phải lớn hơn 0");
            }
            else if (good.type.value == "") 
            {
                return new AddGoodReponse<String>(0, "Loại hàng không được bỏ trống");
            }
            else if (good.price < 0)
            {
                return new AddGoodReponse<String>(0, "Đơn giá phải lớn hơn 0");
            } 
            else if (good.expiredDate < DateTime.UtcNow) {
                return new AddGoodReponse<String>(0, "Hạn sử dụng phải lớn hơn ngày hiện tại");
            } else
            {
                good_DAL.addGood(good);
                return new AddGoodReponse<String>(1, "Thêm hàng thành công");
            }
        }

        public List<Good_DTO> searchGood(string searchValue)
        {
            if (searchValue.Equals("")) {
                return good_DAL.getGoods();
            } 
            else
            { 
                return good_DAL.searchGood(searchValue);
            }
        }

        public void updateGood(Good_DTO good_DTO)
        {
            good_DAL.updateGood(good_DTO);
        }
    }
}
