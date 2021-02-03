using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AdoNetDemo
{
    public class ProductDal
    {
        public List<Product> GetAll()
        {

            SqlConnection connection = new SqlConnection(@"server=(localdb)\MSSQLLocalDB;initial catalog=Etrade; integrated security=true");
            if (connection.State==ConnectionState.Closed)
            {
                connection.Open();
            }
            SqlCommand command = new SqlCommand("select * from Products",connection);
            SqlDataReader reader = command.ExecuteReader();

            List<Product> products = new List<Product>();
            while (reader.Read())
            {
                Product product = new Product {ProductId=Convert.ToInt32(reader["ProductId"]),
                    CategoryId= Convert.ToInt32(reader["CategoryId"]),ProductName=reader["Name"].ToString(),
                UnitPrice=Convert.ToDecimal(reader["UnitPrice"]),StockAmount=Convert.ToInt32(reader["StockAmount"]) };
                products.Add(product);
            }

            reader.Close();
            connection.Close();
            return products;



            
        }

        public DataTable GetAll2()
        {

            SqlConnection connection = new SqlConnection(@"server=(localdb)\MSSQLLocalDB;initial catalog=Etrade; integrated security=true");
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
            SqlCommand command = new SqlCommand("select * from Products", connection);
            SqlDataReader reader = command.ExecuteReader();

            DataTable dataTable = new DataTable();
            dataTable.Load(reader);

            reader.Close();
            connection.Close();
            return dataTable;




        }
    }
}
