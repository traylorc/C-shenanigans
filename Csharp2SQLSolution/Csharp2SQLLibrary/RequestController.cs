using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace Csharp2SQLLibrary
{
    public class RequestController
    {
        private static Connection connection { get; set; }

        public RequestController(Connection connection)
        {
            RequestController.connection = connection;
        }


        private void FillCmdParFromSqlRowsForResults(SqlCommand cmd, Request result)
        {
            cmd.Parameters.AddWithValue("@userid", result.UserId);
            cmd.Parameters.AddWithValue("@description", result.Description);
            cmd.Parameters.AddWithValue("@justification", result.Justification);
            cmd.Parameters.AddWithValue("@rejectreasoning", result.RejectReasoning);
            cmd.Parameters.AddWithValue("@deliverymode", result.DeliveryMode);
            cmd.Parameters.AddWithValue("@status", result.Status);
            cmd.Parameters.AddWithValue("@total", result.Total);
        }

        public bool Create(Request request, string UserUsername)
        {
            var userCtrl = new UserController(connection);
            var user = userCtrl.GetByUsername(UserUsername);
            request.UserId = user.Id;
            return Create(request);
        }

        public bool Create (Request request)
        {
            var sql = " Insert into Requests" +
                " (UserId, Description, Justification, RejectReasoning, DeliveryMode, Status, Total)" +
                "Values (@userid, @description, @justification, @rejectreasonint, @deliverymode, @status, @total);";
            var cmd = new SqlCommand(sql, connection.SqlConn);

            FillCmdParFromSqlRowsForResults(cmd, request);

            var rowsaffected = cmd.ExecuteNonQuery();
            return (rowsaffected == 1);
        }
        public bool Change(Request request)
        {
            var sql = " Update Requests set" +
                " (UserId, Description, Justification, RejectReasoning, DeliveryMode, Status, Total)" +
                "Values (@userid, @description, @justification, @rejectreasonint, @deliverymode, @status, @total);";
            var cmd = new SqlCommand(sql, connection.SqlConn);

            FillCmdParFromSqlRowsForResults(cmd, request);

            var rowsaffected = cmd.ExecuteNonQuery();
            return (rowsaffected == 1);
        }

        public bool Remove(int id)
        {
            var sql = $" DELETE From Requests " +
                       " Where Id = @id; ";

            var cmd = new SqlCommand(sql, connection.SqlConn);
            cmd.Parameters.AddWithValue("@id", id);
            var rowsaffected = cmd.ExecuteNonQuery();

            return (rowsaffected == 1);
        }

        private void GetUserForRequest(Request request)
        {
            var userCtrl = new UserController(connection);
            request.user = userCtrl.GetByPk(request.UserId);               
        }

        private Request FillRequestFromSqlRow(SqlDataReader reader)
        {
            var request = new Request()
            {
                Id = Convert.ToInt32(reader["Id"]),
                UserId = Convert.ToInt32(reader["UserId"]),
                Description = Convert.ToString(reader["Description"]),
                Justification = Convert.ToString(reader["Justification"]),
                RejectReasoning = Convert.ToString(reader["RejectReasoning"]),
                DeliveryMode = Convert.ToString(reader["DeliveryMode"]),
                Status = Convert.ToString(reader["Status"]),
                Total = Convert.ToDecimal(reader["Total"])
            };
            return request;
        }

        public List<Request> GetAllRequests()
        {
            var sql = $" SELECT * from Requests; ";
            var cmd = new SqlCommand(sql, connection.SqlConn);
            var reader = cmd.ExecuteReader();
            var requests = new List<Request>();

            while (reader.Read())
            {
                var request = FillRequestFromSqlRow(reader);
                requests.Add(request);
            }
            reader.Close();
            return requests;
        }

        public Request GetByPk(int id)
        {
            var sql = $"SELECT * From Requests where id = {id};";
            var cmd = new SqlCommand(sql, connection.SqlConn);
            var reader = cmd.ExecuteReader();
            if (!reader.HasRows)
            {
                reader.Close();
                return null;
            }
            reader.Read();
            var request = FillRequestFromSqlRow(reader);
            reader.Close();
            return request;
        }
    }


}
