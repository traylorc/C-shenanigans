using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace Csharp2SQLLibrary
{
    public class ProductController
    {
        private static Connection connection { get; set; }

        public ProductController(Connection connection)
        {
            ProductController.connection = connection;
        }


        public bool Create(Product product, string VendorCode)
        {
            var vendCtrl = new VendorsController(connection);
            var vendor = vendCtrl.GetByCode(VendorCode);
            product.VendorId = vendor.Id;
            return Create(product);
        }

        private void FillCmdParFromSqlRowsForProducts(SqlCommand cmd, Product product)
        {
            cmd.Parameters.AddWithValue("@partnbr", product.PartNbr);
            cmd.Parameters.AddWithValue("@name", product.Name);
            cmd.Parameters.AddWithValue("@price", product.Price);
            cmd.Parameters.AddWithValue("@unit", product.Unit);
            cmd.Parameters.AddWithValue("@photopath", (object)product.PhotoPath ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@vendorid", product.VendorId);
        }


        public bool Create(Product product)
        {
            var sql = " INSERT into Products" +
                " (PartNbr, Name, Price, Unit, PhotoPath, VendorId) " +
                " VALUES (@partnbr, @name, @price, @unit, @photopath, @vendorid); ";
            var cmd = new SqlCommand(sql, connection.SqlConn);

            FillCmdParFromSqlRowsForProducts(cmd, product);

            var rowsaffected = cmd.ExecuteNonQuery();
            return (rowsaffected == 1);
        }

        private void GetVendorForProducts(List<Product> products)
        {
            foreach(var product in products)
            {
                GetVendorForProduct(product);
            }
        }

        private void GetVendorForProduct(Product product)
        {
            var vendCtrl = new VendorsController(connection);
            product.vendor = vendCtrl.GetByPk(product.VendorId);
        }

        private Product FillProductFromSqlRow(SqlDataReader reader)
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
            return product;
        }


        public List<Product> GetAllProducts()
        {
            var sql = $" SELECT * from Products; ";
            var cmd = new SqlCommand(sql, connection.SqlConn);
            var reader = cmd.ExecuteReader();
            var products = new List<Product>();

            while (reader.Read())
            {
                var product = FillProductFromSqlRow(reader);
                products.Add(product);
            }
            reader.Close();
            return products;
        }
    }
}
