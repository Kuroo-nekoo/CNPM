using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Good_DAL
    {
        SqlConnection sqlConnection = SqlConnectionData.Connect();
        SqlDataReader sqlDataReader;
        public List<Good> getGoods()
        {
            List<Good> goods = new List<Good>();

            try
            {
                SqlCommand sqlCommand = new SqlCommand()
                {
                    CommandTimeout = 60,
                    Connection = sqlConnection,
                    CommandType = System.Data.CommandType.Text,
                    CommandText = "select Good.id, goodName, GoodType.goodTypeValue, amount, price, expiredDate from Good left join GoodType on Good.goodTypeId = GoodType.id"
                };

                sqlConnection.Open();

                if (sqlConnection.State == System.Data.ConnectionState.Open)
                {
                    sqlDataReader = sqlCommand.ExecuteReader();
                    if (sqlDataReader.HasRows)
                    {
                        while (sqlDataReader.Read())
                        {
                            Console.WriteLine(sqlDataReader.GetString(1));
                            string id = sqlDataReader.GetString(0);
                            string name = sqlDataReader.GetString(1);
                            string goodType = sqlDataReader.GetString(2);
                            int amount = sqlDataReader.GetInt32(3);
                            double price = sqlDataReader.GetDouble(4);
                            DateTime expiredDate = sqlDataReader.GetDateTime(5);

                            goods.Add(new Good(id, name, goodType, amount, price, expiredDate));
                        }
                    }

                }

                sqlConnection.Close();
            }
            catch
            {
                sqlConnection.Close();
            }

            return goods;
        }

        public void deleteGood(string id)
        {
            try
            {
                SqlCommand sqlCommand = new SqlCommand()
                {
                    CommandTimeout = 60,
                    Connection = sqlConnection,
                    CommandType = System.Data.CommandType.Text,
                    CommandText = "delete from Good where Good.id = @id",
                };

                sqlCommand.Parameters.AddWithValue("@id", id);

                sqlConnection.Open();
                sqlCommand.ExecuteReader();
                sqlConnection.Close();
            } 
            catch
            {
                sqlConnection.Close();
            }
        }
    }
}
