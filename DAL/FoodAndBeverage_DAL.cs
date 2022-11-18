using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DAL
{
    public class FoodAndBeverage_DAL
    {
        SqlConnection sqlConnection = SqlConnectionData.Connect();
        SqlDataReader sqlDataReader;

        public List<FoodAndBeverage_DTO> getFoodAndBeveragesByType(string type)
        {
            List<FoodAndBeverage_DTO> foodAndBeverageList = new List<FoodAndBeverage_DTO>();
            try
            {
                SqlCommand sqlCommand = new SqlCommand()
                {
                    CommandTimeout = 60,
                    CommandType = System.Data.CommandType.Text,
                    CommandText = "select * from FoodAndBeverage left join FoodAndBeverageType on FoodAndBeverage.foodAndBeverageTypeId = FoodAndBeverageType.id where FoodAndBeverageType.id = @type",
                    Connection = sqlConnection
                };

                sqlCommand.Parameters.AddWithValue("@type", type);

                sqlConnection.Open();

                if (sqlConnection.State == System.Data.ConnectionState.Open)
                {
                    sqlDataReader = sqlCommand.ExecuteReader();

                    if (sqlDataReader.HasRows)
                    {
                        while (sqlDataReader.Read())
                        {
                            int id = sqlDataReader.GetInt32(0);
                            string name = sqlDataReader.GetString(1);
                            double price = sqlDataReader.GetDouble(2);
                            string size = sqlDataReader.GetString(4);

                            foodAndBeverageList.Add(new FoodAndBeverage_DTO(id, name, price, 0, size));
                        }
                    }
                }
            }
            catch
            {
                sqlConnection.Close();
            }
            return foodAndBeverageList;
        }
    }
}
