using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Supplier_BLL
    {
        private Supplier_DAL supplier_DAL = new Supplier_DAL();
        public List<Supplier_DTO> getSuppliers()
        {
            return supplier_DAL.getSuppliers();
        }

        public List<Supplier_DTO> searchSupplier(string searchValue)
        {
            if (searchValue.Equals(""))
            {
                return supplier_DAL.getSuppliers();
            } 
            else
            {
                return supplier_DAL.searchSupplier(searchValue);
            }
        }

        public void deleteSupplier (string id)
        {
            supplier_DAL.deleteSupplier(id);
        }
    }
}
