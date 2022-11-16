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
        SqlConnection sqlConnection = SqlConnectionData.Connect();
        SqlDataReader sqlDataReader;
        public List<GoodType_DTO> getGoodTypes()
        { 
            List<GoodType_DTO> goodTypeList = new List<GoodType_DTO>();

            try
            {
                SqlCommand sqlCommand = new SqlCommand()
                {
                    CommandType = System.Data.CommandType.Text,
                    CommandText = "select * from goodType",
                    Connection = sqlConnection,
                    CommandTimeout = 60
                };

                sqlDataReader = sqlCommand.ExecuteReader();
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
            }
            catch
            {
                sqlConnection.Close();
            }

            return goodTypeList;
        }
    }
}
