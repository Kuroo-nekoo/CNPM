using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class FoodAndBeverageType_DAL
    {
        SqlConnection sqlConnection = SqlConnectionData.Connect();
        SqlDataReader sqlDataReader;

        public List<FoodAndBeverageType_DTO> getFoodAndBeverageTypes() {
            List<FoodAndBeverageType_DTO> foodAndBeverageTypes = new List<FoodAndBeverageType_DTO>();
            
            try
            {
                SqlCommand sqlCommand = new SqlCommand()
                {
                    CommandTimeout = 60,
                    Connection = sqlConnection,
                    CommandType = System.Data.CommandType.Text,
                    CommandText = "select * from FoodAndBeverageType"
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
                            string type = sqlDataReader.GetString(1);

                            foodAndBeverageTypes.Add(new FoodAndBeverageType_DTO(id, type));
                        }
                    }
                }
                sqlConnection.Close();
            }
            catch
            {
                sqlConnection.Close();
            }
            return foodAndBeverageTypes;
        }
    }
}
