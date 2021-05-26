using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace Csharp2SQLLibrary
{
    public class ProductController
    {
        private static Connection connection { get; set; }


        public List<Product> GetAllProducts()
        {
            var sql = $" SELECT * from Products; ";
            var cmd = new SqlCommand(sql, connection.SqlConn);
            var reader = cmd.ExecuteReader();
            var products = new List<Product>();

            while (reader.Read())
            {
                var product = new Product()
                {
                    Id = Convert.ToInt32(reader["Id"]),
                    VendorId = Convert.ToInt32(reader["VendorId"]),
                    PartNbr = Convert.ToString(reader["PartNbr"]),
                    Name = Convert.ToString(reader["Name"]),
                    Price = Convert.ToDecimal(reader["Price"]),
                    Unit = Convert.ToString(reader["Unit"]),
                    PhotoPath = Convert.ToString(reader["PhotoPath"])
                };
                products.Add(product);
            }
            reader.Close();
            return products;
        }
    }
}
