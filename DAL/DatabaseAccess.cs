using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class SqlConnectionData
    {
 
        public static SqlConnection Connect()
        {
            return new SqlConnection(@"Data Source=ADMIN-PC\HUNG;Initial Catalog=HighLandsManagement;Integrated Security=True");
        }
    }
}
