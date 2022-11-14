using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class SqlConnectionData
    {
 
        public static SqlConnection Connect()
            {
                return new SqlConnection(@"Data Source=ADMIN-PC\HUNG;Initial Catalog=HighLandsManagement;Integrated Security=True");
            }
    }
    
    public class DatabaseAccess
    {
        public void getGoods()
        {
            SqlConnection sqlConnection = SqlConnectionData.Connect();
            string query = "SELECT * FROM GOOD";
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
            sqlConnection.Open();
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            try
            {
                while (sqlDataReader.Read())
                {
                    Debug.WriteLine("test");
                }
            } 
            catch
            {
                sqlDataReader.Close();
            }
        }
    }
}
