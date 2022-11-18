using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class Supplier_DAL
    {
        SqlConnection sqlConnection = SqlConnectionData.Connect();
        SqlDataReader sqlDataReader;

        public List<Supplier_DTO> getSuppliers()
        {
            List<Supplier_DTO> suppliers = new List<Supplier_DTO>();


            try
            {
                SqlCommand sqlCommand = new SqlCommand()
                {
                    CommandTimeout = 60,
                    CommandType = System.Data.CommandType.Text,
                    CommandText = "select * from Supplier",
                    Connection = sqlConnection
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
                            string address = sqlDataReader.GetString(2);
                            string phone = sqlDataReader.GetString(3);

                            suppliers.Add(new Supplier_DTO(id, name, address, phone));
                        }
                    }
                }
                sqlConnection.Close();
            }
            catch
            {
                sqlConnection.Close();
            }

            return suppliers;
        }
        public List<Supplier_DTO> searchSupplier(string searchValue)
        {
            List<Supplier_DTO> suppliers = new List<Supplier_DTO>();

            try
            {
                SqlCommand sqlCommand = new SqlCommand()
                {
                    CommandTimeout = 60,
                    Connection = sqlConnection,
                    CommandType = System.Data.CommandType.Text,
                    CommandText = "select * from Supplier where Supplier.supplierName like '%'+@searchValue+'%'",
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
                            string address = sqlDataReader.GetString(2);
                            string phone = sqlDataReader.GetString(3);


                            suppliers.Add(new Supplier_DTO(id, name, address, phone));
                        }
                    }
                }
                sqlConnection.Close();
            }
            catch
            {
                sqlConnection.Close();
            }
            return suppliers;
        }
        public void deleteSupplier(string id)
        {
            try
            {
                SqlCommand sqlCommand = new SqlCommand()
                {
                    CommandTimeout = 60,
                    Connection = sqlConnection,
                    CommandType = System.Data.CommandType.Text,
                    CommandText = "delete from Supplier where Supplier.id = @id",
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

