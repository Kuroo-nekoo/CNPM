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
        public List<Good_DTO> getGoods()
        {
            List<Good_DTO> goods = new List<Good_DTO>();

            try
            {
                SqlCommand sqlCommand = new SqlCommand()
                {
                    CommandTimeout = 60,
                    Connection = sqlConnection,
                    CommandType = System.Data.CommandType.Text,
                    CommandText = "select Good.id as goodId, goodName, GoodType.id as goodTypeId, GoodType.goodTypeValue, amount, price, expiredDate from Good left join GoodType on Good.goodTypeId = GoodType.id"
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
                            string name = sqlDataReader.GetString(1);
                            int goodTypeId = sqlDataReader.GetInt32(2);
                            string goodType = sqlDataReader.GetString(3);
                            int amount = sqlDataReader.GetInt32(4);
                            double price = sqlDataReader.GetDouble(5);
                            DateTime expiredDate = sqlDataReader.GetDateTime(6);

                            goods.Add(new Good_DTO(id, name, new GoodType_DTO(goodTypeId, goodType), amount, price, expiredDate));
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

        public List<Good_DTO> filterGood(string filteredType)
        {
            List<Good_DTO> goods = new List<Good_DTO>();

            try
            {
                SqlCommand sqlCommand = new SqlCommand()
                {
                    CommandTimeout = 60,
                    Connection = sqlConnection,
                    CommandType = System.Data.CommandType.Text,
                    CommandText = "select Good.id, goodName, Good.goodTypeId, GoodType.goodTypeValue, amount, price, expiredDate from Good left join GoodType on Good.goodTypeId = GoodType.id where GoodType.goodTypeValue = @goodType",
                };

                sqlCommand.Parameters.AddWithValue("@goodType", filteredType);

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
                            int goodTypeId = sqlDataReader.GetInt32(2);
                            string goodType = sqlDataReader.GetString(3);
                            int amount = sqlDataReader.GetInt32(4);
                            double price = sqlDataReader.GetDouble(5);
                            DateTime expiredDate = sqlDataReader.GetDateTime(6);

                            goods.Add(new Good_DTO(id, name, new GoodType_DTO(goodTypeId, goodType), amount, price, expiredDate));
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

        public void addGood(Good_DTO good)
        {
            try
            {
                SqlCommand sqlCommand = new SqlCommand()
                {
                    CommandTimeout = 60,
                    Connection = sqlConnection,
                    CommandType = System.Data.CommandType.Text,
                    CommandText = "insert into Good values (@name, @amount, @price, @goodTypeId, @expiredDate)",
                };

                sqlCommand.Parameters.AddWithValue("@name", good.name);
                sqlCommand.Parameters.AddWithValue("@amount", good.amount);
                sqlCommand.Parameters.AddWithValue("@price", good.price);
                sqlCommand.Parameters.AddWithValue("@goodTypeId", good.type.id);
                sqlCommand.Parameters.AddWithValue("@expiredDate", good.expiredDate);

                sqlConnection.Open();
                sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();
            }
            catch
            {
                sqlConnection.Close();
            }
        }

        public List<Good_DTO> searchGood(string searchValue)
        {
            List<Good_DTO> goodList = new List<Good_DTO>();

            try
            {
                SqlCommand sqlCommand = new SqlCommand()
                {
                    CommandTimeout = 60,
                    Connection = sqlConnection,
                    CommandType = System.Data.CommandType.Text,
                    CommandText = "select Good.id, goodName, Good.goodTypeId, GoodType.goodTypeValue, amount, price, expiredDate from Good left join GoodType on Good.goodTypeId = GoodType.id where Good.goodName like '%'+@searchValue+'%'",
                };

                sqlCommand.Parameters.AddWithValue("@searchValue", searchValue);
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
                            int goodTypeId = sqlDataReader.GetInt32(2);
                            string goodType = sqlDataReader.GetString(3);
                            int amount = sqlDataReader.GetInt32(4);
                            double price = sqlDataReader.GetDouble(5);
                            DateTime expiredDate = sqlDataReader.GetDateTime(6);


                            goodList.Add(new Good_DTO(id, name, new GoodType_DTO(goodTypeId, goodType), amount, price, expiredDate));
                        }
                    }
                }
            }
            catch
            {
                sqlConnection.Close();
            }
            return goodList;
        }

        public void updateGood(Good_DTO good)
        {
            try
            {
                SqlCommand sqlCommand = new SqlCommand()
                {
                    CommandTimeout = 60,
                    Connection = sqlConnection,
                    CommandType = System.Data.CommandType.Text,
                    CommandText = "update Good set goodName = @name, amount = @amount, price = @price, goodTypeId = @goodTypeId, expiredDate = @expiredDate where Good.id = @id",
                };

                sqlCommand.Parameters.AddWithValue("@name", good.name);
                sqlCommand.Parameters.AddWithValue("@amount", good.amount);
                sqlCommand.Parameters.AddWithValue("@price", good.price);
                sqlCommand.Parameters.AddWithValue("@goodTypeId", good.type.id);
                sqlCommand.Parameters.AddWithValue("@expiredDate", Convert.ToDateTime(good.expiredDate));
                sqlCommand.Parameters.AddWithValue("@id", good.id);

                sqlConnection.Open();
                int res = sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();
            }
            catch
            {
                sqlConnection.Close();
            }
        }
    }
}
