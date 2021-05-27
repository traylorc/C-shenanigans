using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace Csharp2SQLLibrary
{
    public class UserController
    {
        private static Connection connection { get; set; }
        
        public UserController(Connection connection)
        {
            UserController.connection = connection;
        }




        private void FillCmdParFromSqlRowsForUsers(SqlCommand cmd, User user)
        {
            cmd.Parameters.AddWithValue("@username", user.Username);
            cmd.Parameters.AddWithValue("@password", user.Password);
            cmd.Parameters.AddWithValue("@firstname", user.Firstname);
            cmd.Parameters.AddWithValue("@lastname", user.Lastname);
            cmd.Parameters.AddWithValue("@phone", user.Phone);
            cmd.Parameters.AddWithValue("@email", user.Email);
            cmd.Parameters.AddWithValue("@isReviewer", user.IsReviewer);
            cmd.Parameters.AddWithValue("@isAdmin", user.IsAdmin);
        }

        public bool Create(User user)
        {
            var sql = " INSERT into Users " +
                " (Username, Password, Firstname, Lastname, Phone, Email, IsReviewer, IsAdmin)" +
                "VALUES (@username, @password, @firstname, @lastname, @phone, @email, @isReviewer, @isAdmin);";
            var cmd = new SqlCommand(sql, connection.SqlConn);

            FillCmdParFromSqlRowsForUsers(cmd, user);

            var rowaffected = cmd.ExecuteNonQuery();
            return (rowaffected == 1);
        }

        public bool Change(User user)
        {
            var sql = " INSERT into Users " +
                " (Username, Password, Firstname, Lastname, Phone, Email, IsReviewer, IsAdmin)" +
                "VALUES (@username, @password, @firstname, @lastname, @phone, @email, @isReviewer, @isAdmin);";
            var cmd = new SqlCommand(sql, connection.SqlConn);

            FillCmdParFromSqlRowsForUsers(cmd, user);

            var rowsaffected = cmd.ExecuteNonQuery();
            return (rowsaffected == 1);
        }

        public bool Remove(User user)
        {
            var sql = " DELETE from Users" +
                    "where Id = @id;";

            var cmd = new SqlCommand(sql, connection.SqlConn);
            cmd.Parameters.AddWithValue("@id", user.Id);
            var rowsaffected = cmd.ExecuteNonQuery();
            return (rowsaffected == 1);


        }
        
        private User FillUsersFromSqlRow(SqlDataReader reader)
        {
            var user = new User()
            {
                Id = Convert.ToInt32(reader["Id"]),
                Username = Convert.ToString(reader["Username"]),
                Password = Convert.ToString(reader["Password"]),
                Firstname = Convert.ToString(reader["Firstname"]),
                Lastname = Convert.ToString(reader["Lastname"]),
                Phone = Convert.ToString(reader["Phone"]),
                Email = Convert.ToString(reader["Email"]),
                IsReviewer = Convert.ToBoolean(reader["IsReviewer"]),
                IsAdmin = Convert.ToBoolean(reader["IsAdmin"])
            };
            return user;
        }

        public List<User> GetAllUsers()
        {
            var sql = $" SELECT * from Users; ";
            var cmd = new SqlCommand(sql, connection.SqlConn);
            var reader = cmd.ExecuteReader();
            var users = new List<User>();

            while (reader.Read())
            {
                var user = FillUsersFromSqlRow(reader);
                users.Add(user);
            }
            reader.Close();
            return users;
        }

        public User GetByPk(int id)
        {
            var sql = $"SELECT * From Users where id = {id};";
            var cmd = new SqlCommand(sql, connection.SqlConn);
            var reader = cmd.ExecuteReader();
            if (!reader.HasRows)
            {
                reader.Close();
                return null;
            }
            reader.Read();
            var vendor = FillUsersFromSqlRow(reader);
            reader.Close();
            return vendor;
        }
    }
}
