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
        

       
        
        private void FillCmdParFromSqlRowsForProducts(SqlCommand cmd, Product product)
        {
            cmd.Parameters.AddWithValue("@partnbr", product.PartNbr);
            cmd.Parameters.AddWithValue("@name", product.Name);
            cmd.Parameters.AddWithValue("@price", product.Price);
            cmd.Parameters.AddWithValue("@unit", product.Unit);
            cmd.Parameters.AddWithValue("@photopath", (object)product.PhotoPath ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@vendorid", product.VendorId);
        }
       
        public bool Create(Product product, string VendorCode)
        {
            var vendCtrl = new VendorsController(connection);
            var vendor = vendCtrl.GetByCode(VendorCode);
            product.VendorId = vendor.Id;
            return Create(product);
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

        public bool Change(Product product)
        {
            var sql = " Update Products set" +
              " (PartNbr, Name, Price, Unit, PhotoPath, VendorId) " +
              " VALUES (@partnbr, @name, @price, @unit, @photopath, @vendorid); ";
            var cmd = new SqlCommand(sql, connection.SqlConn);

            FillCmdParFromSqlRowsForProducts(cmd, product);

            var rowsaffected = cmd.ExecuteNonQuery();
            return (rowsaffected == 1);
        }

        public bool Remove(int id)
        {
            var sql = $" DELETE From Products " +
                       " Where Id = @id; ";

            var cmd = new SqlCommand(sql, connection.SqlConn);
            cmd.Parameters.AddWithValue("@id", id);
            var rowsaffected = cmd.ExecuteNonQuery();

            return (rowsaffected == 1);
        }

        private void GetVendorForProduct(Product product)
        {
            var vendCtrl = new VendorsController(connection);
            product.vendor = vendCtrl.GetByPk(product.VendorId);
        }

        private void GetVendorForProducts(List<Product> products)
        {
            foreach(var product in products)
            {
                GetVendorForProduct(product);
            }
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

        public Product GetByPk(int id)
        {
            var sql = $"SELECT * From Products where id = {id};";
            var cmd = new SqlCommand(sql, connection.SqlConn);
            var reader = cmd.ExecuteReader();
            if (!reader.HasRows)
            {
                reader.Close();
                return null;
            }
            reader.Read();
            var product = FillProductFromSqlRow(reader);
            reader.Close();
            return product;
        }
    }
}
