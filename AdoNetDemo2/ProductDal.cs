using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoNetDemo2
{
    public class ProductDal
    {
        SqlConnection _connection = new SqlConnection(@"server=(localdb)\MSSQLLocalDB;initial catalog=ETrade;integrated security=true");
        public List<Product> GetAll()
        {
            ConnectionControl();
            SqlCommand command = new SqlCommand("select * from Products", _connection);
            SqlDataReader reader = command.ExecuteReader();

            List<Product> products = new List<Product>();

            while (reader.Read())
            {
                Product product = new Product
                {
                    ProductId = Convert.ToInt32(reader["ProductId"]),
                    CategoryId = Convert.ToInt32(reader["CategoryId"]),
                    ProductName = reader["ProductName"].ToString(),
                    UnitPrice = Convert.ToDecimal(reader["UnitPrice"]),
                    StockAmount = Convert.ToInt32(reader["StockAmount"])
                };
                products.Add(product);
            }
            reader.Close();
            _connection.Close();
            return products;
        }

        private void ConnectionControl()
        {
            if (_connection.State == ConnectionState.Closed)
            {
                _connection.Open();
            }
        }

        public void Add(Product product)
        {
            ConnectionControl();
            SqlCommand command = new SqlCommand("insert into Products values(@CategoryId,@ProductName," +
                "@UnitPrice,@StockAmount)",_connection);
            command.Parameters.AddWithValue("@CategoryId",product.CategoryId);
            command.Parameters.AddWithValue("@ProductName", product.ProductName);
            command.Parameters.AddWithValue("@UnitPrice", product.UnitPrice);
            command.Parameters.AddWithValue("@StockAmount", product.StockAmount);

            command.ExecuteNonQuery();
            _connection.Close();
        }
        public void Updated(Product product)
        {
            ConnectionControl();
            SqlCommand command = new SqlCommand("update Products set CategoryId=@CategoryId,ProductName=@ProductName," +
                "UnitPrice=@UnitPrice,StockAmount=@StockAmount where ProductId=@ProductId", _connection);
            command.Parameters.AddWithValue("@ProductId", product.ProductId);
            command.Parameters.AddWithValue("@CategoryId", product.CategoryId);
            command.Parameters.AddWithValue("@ProductName", product.ProductName);
            command.Parameters.AddWithValue("@UnitPrice", product.UnitPrice);
            command.Parameters.AddWithValue("@StockAmount", product.StockAmount);

            command.ExecuteNonQuery();
            _connection.Close();
        }
        public void Delete(int productId)
        {
            ConnectionControl();
            SqlCommand command = new SqlCommand("Delete from Products where ProductId=@ProductId", _connection);
            command.Parameters.AddWithValue("@ProductId",productId);
            command.ExecuteNonQuery();
            _connection.Close();
        }





    }
    //public DataTable GetAll2()
    //{

    //    SqlConnection connection = new SqlConnection(@"server=(localdb)\MSSQLLocalDB;initial catalog=ETrade;integrated security=true");
    //    if (connection.State == ConnectionState.Closed)
    //    {
    //        connection.Open();
    //    }
    //    SqlCommand command = new SqlCommand("select * from Products", connection);
    //    SqlDataReader reader = command.ExecuteReader();

    //    DataTable dataTable = new DataTable();
    //    dataTable.Load(reader);

    //    reader.Close();
    //    connection.Close();
    //    return dataTable;





    //}


}
