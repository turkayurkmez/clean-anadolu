using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsibility
{
    public class ProductService
    {
        public int CreateNewProduct(string productName, decimal price)
        {
            DbHelper dbHelper = new DbHelper();
            var query = "insert into Products(ProductName, ProductPrice) values(@productName, @productPrice)";
            var parameters = new Dictionary<string, object>
            {
                {"@productName", productName},
                {"@productPrice", price}
            };
            return dbHelper.ExecuteNonQuery(query, parameters);
        
        }

        public int DeleteProduct(int productId)
        {
            /* SqlConnection connection = new SqlConnection("connectionString");
             * SqlCommand command = new SqlCommand("delete from Products where ProductId = @productId", connection);
             * command.Parameters.AddWithValue("@productId", productId);
             * command.Connection.Open();
             * int affectedRows = command.ExecuteNonQuery();
             * command.Connection.Close();
            */
            return 1;
        }

        public int UpdateProduct(int productId, string productName, decimal price)
        {
            /* SqlConnection connection = new SqlConnection("connectionString");
             * SqlCommand command = new SqlCommand("update Products set ProductName = @productName, ProductPrice = @productPrice where ProductId = @productId", connection);
             * command.Parameters.AddWithValue("@productName", productName);
             * command.Parameters.AddWithValue("@productPrice", price);
             * command.Parameters.AddWithValue("@productId", productId);
             * command.Connection.Open();
             * int affectedRows = command.ExecuteNonQuery();
             * command.Connection.Close();
            */
            return 1;
        }
    }
}
