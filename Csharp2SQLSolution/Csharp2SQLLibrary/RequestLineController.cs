using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace Csharp2SQLLibrary
{
    public class RequestLineController
    {
        private static Connection connection { get; set; }

        public RequestLineController(Connection connection)
        {
            RequestLineController.connection = connection;
        }

        private void FillCmdParFromSqlRowsForRequestLines(SqlCommand cmd, RequestLine requestLine)
        {
            cmd.Parameters.AddWithValue("@requestid", requestLine.RequestId);
            cmd.Parameters.AddWithValue("@productid", requestLine.ProductId);
            cmd.Parameters.AddWithValue("@quantity", requestLine.Quantity);
        }

        public bool Create(RequestLine requestline, string RequestDescription)
        {
            var RequestCtrl = new RequestController(connection);
            var request = RequestCtrl.GetByDescription(RequestDescription);
            requestline.RequestId = request.Id;
            return Create(requestline);
        }

        public bool CreateP(RequestLine requestline, string ProductName)
        {
            var productctrl = new ProductController(connection);
            var product = productctrl.GetByName(ProductName);
            requestline.ProductId = product.Id;
            return Create(requestline);
        }

        public bool Create(RequestLine requestLine)
        {
            var sql = "Insert into RequestLines" +
                " (RequestId, ProductId, Quantity) " +
                "Values (@requestid, @productid, @quantity);";
            var cmd = new SqlCommand(sql, connection.SqlConn);

            FillCmdParFromSqlRowsForRequestLines(cmd, requestLine);

            var rowsaffected = cmd.ExecuteNonQuery();
            return (rowsaffected == 1);
        }

        public bool Change(RequestLine requestLine)
        {
            var sql = "Update RequestLines set" +
                " (RequestId, ProductId, Quantity) " +
                "Values (@requestid, @productid, @quantity);";
            var cmd = new SqlCommand(sql, connection.SqlConn);

            FillCmdParFromSqlRowsForRequestLines(cmd, requestLine);

            var rowsaffected = cmd.ExecuteNonQuery();
            return (rowsaffected == 1);
        }

        public bool Remove(int id)
        {
            var sql = "Delete from Requestlines " +
                " where Id = @id; ";

            var cmd = new SqlCommand(sql, connection.SqlConn);
            cmd.Parameters.AddWithValue("@id", id);
            var rowsaffected = cmd.ExecuteNonQuery();
            return (rowsaffected == 1);
        }

        private void GetRequestForRequestLine(RequestLine requestLine)
        {
            var requestctrl = new RequestController(connection);
            requestLine.request = requestctrl.GetByPk(requestLine.RequestId);
        }
        private void GetProductForRequestLine(RequestLine requestLine)
        {
            var productctrl = new ProductController(connection);
            requestLine.product = productctrl.GetByPk(requestLine.ProductId);
        }

        private RequestLine FillRequestLineFromSqlRow(SqlDataReader reader)
        {
            var requestline = new RequestLine()
            {
                Id = Convert.ToInt32(reader["Id"]),
                RequestId = Convert.ToInt32(reader["RequestId"]),
                ProductId = Convert.ToInt32(reader["ProductId"]),
                Quantity = Convert.ToInt32(reader["Quantity"])
               
            };
            return requestline;
        }

        public List<RequestLine> GetAllRequestLines()
        {
            var sql = $" SELECT * from RequestLines; ";
            var cmd = new SqlCommand(sql, connection.SqlConn);
            var reader = cmd.ExecuteReader();
            var requestlines = new List<RequestLine>();

            while (reader.Read())
            {
                var requestline = FillRequestLineFromSqlRow(reader);
                requestlines.Add(requestline);
            }
            reader.Close();
            return requestlines;
        }

        public RequestLine GetByPk(int id)
        {
            var sql = $"SELECT * From Requestlines where id = {id};";
            var cmd = new SqlCommand(sql, connection.SqlConn);
            var reader = cmd.ExecuteReader();
            if (!reader.HasRows)
            {
                reader.Close();
                return null;
            }
            reader.Read();
            var requestline = FillRequestLineFromSqlRow(reader);
            reader.Close();
            return requestline;
        }

    }

}
