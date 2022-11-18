using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class GoodType_DAL
    {
        SqlConnection sqlConnection;
        SqlDataReader sqlDataReader;
        public GoodType_DAL ()
        {
            sqlConnection = SqlConnectionData.Connect();
        }
        public List<GoodType_DTO> getGoodTypes()
        { 
            List<GoodType_DTO> goodTypeList = new List<GoodType_DTO>();

            try
            {
                SqlCommand sqlCommand = new SqlCommand()
                {
                    CommandType = System.Data.CommandType.Text,
                    CommandText = "select * from GoodType",
                    Connection = sqlConnection,
                    CommandTimeout = 60
                };

                
                sqlConnection.Open();
                if (sqlConnection.State == System.Data.ConnectionState.Open)
                {
                    sqlDataReader = sqlCommand.ExecuteReader();

                    if (sqlDataReader.HasRows)
                    {
                        while (sqlDataReader.Read())
                        {
                            int id = sqlDataReader.GetInt32(0);
                            String value = sqlDataReader.GetString(1);
                            goodTypeList.Add(new GoodType_DTO(id, value));
                        }
                    }
                }
                sqlConnection.Close();
            }
            catch
            {
                sqlConnection.Close();
            }

            return goodTypeList;
        }
    }
}
