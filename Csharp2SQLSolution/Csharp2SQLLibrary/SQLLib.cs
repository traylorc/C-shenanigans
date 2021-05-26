using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;

namespace Csharp2SQLLibrary
{
    public class SQLLib
    {
        //set property for connection
        public SqlConnection sqlconn { get; set; }


        public bool Remove(User user)
        {
            // create var to stuff sql statment into
            var sql = $" Delete from Users " +                        
                        " Where Id = @id; ";

            var sqlcmd = new SqlCommand(sql, sqlconn);           
            sqlcmd.Parameters.AddWithValue("@id", user.Id);
            var rowsaffected = sqlcmd.ExecuteNonQuery();

            return (rowsaffected == 1);
        }



        //create user instance
        public bool Change(User user)
        {
            // create var to stuff sql statment into
            var sql = $"UPDATE Users Set " +
                        " Username = @username, " +
                        " Password = @password, " +
                        " Firstname = @firstname, " +
                        " Lastname = @lastname, " +
                        " Phone = @phone, " +
                        " Email = @email, " +
                        " IsReviewer = @isreviewer " +
                        " IsAdmin = @isadmin " +
                        " Where Id = @id; ";

            var sqlcmd = new SqlCommand(sql, sqlconn);

            sqlcmd.Parameters.AddWithValue("@username", user.Username);
            sqlcmd.Parameters.AddWithValue("@password", user.Password);
            sqlcmd.Parameters.AddWithValue("@firstname", user.Firstname);
            sqlcmd.Parameters.AddWithValue("@lastname", user.Lastname);
            sqlcmd.Parameters.AddWithValue("@phone", user.Phone);
            sqlcmd.Parameters.AddWithValue("@email", user.Email);
            sqlcmd.Parameters.AddWithValue("@isreviewer", user.IsReviewer);
            sqlcmd.Parameters.AddWithValue("@isadmin", user.IsAdmin);
            sqlcmd.Parameters.AddWithValue("@id", user.Id);
            var rowsaffected = sqlcmd.ExecuteNonQuery();

            return (rowsaffected == 1);
        }


        // to create multiple users at once
        public bool CreateMultiple(List<User> users)
        {
            var success = true;
            foreach(var user in users)
            {
                //if create works, create user is true. success is already true. true and true = true, 
                success = success && Create(user);
            }
            return true;
        }


        // boolean statement to say did this work or not, to create single user
        public bool Create(User user)
        {
            var sql = $"INSERT into Users" +
                "(Username, Password, Firstname, Lastname, Phone, Email, IsReviewer, IsAdmin)" +
                " Values " +
               $" (@username, @password, @firstname, @lastname, " +
               $" @phone, @email, @isreviewer, @isadmin); ";
            var sqlcmd = new SqlCommand(sql, sqlconn);

            sqlcmd.Parameters.AddWithValue("@username", user.Username);
            sqlcmd.Parameters.AddWithValue("@password", user.Password);
            sqlcmd.Parameters.AddWithValue("@firstname", user.Firstname);
            sqlcmd.Parameters.AddWithValue("@lastname", user.Lastname);
            sqlcmd.Parameters.AddWithValue("@phone", user.Phone);
            sqlcmd.Parameters.AddWithValue("@email", user.Email);
            sqlcmd.Parameters.AddWithValue("@isreviewer", user.IsReviewer);
            sqlcmd.Parameters.AddWithValue("@isadmin", user.IsAdmin);
            var rowsaffected = sqlcmd.ExecuteNonQuery();
           
            return (rowsaffected == 1);
        }


        public List<Vendor> GetAllVendors()
        {
            //add in SQL Statement
            var sql = "SELECT * From Vendors;";
            //set new instance of SqlCommand
            var sqlcmd = new SqlCommand(sql, sqlconn);
            //reader brings back results so you can read them
            var sqldatareader = sqlcmd.ExecuteReader();

            var vndrs = new List<Vendor>();

            while (sqldatareader.Read())
            {
                var id = Convert.ToInt32(sqldatareader["Id"]);
                var code = Convert.ToString(sqldatareader["Code"]);
                var name = sqldatareader["Name"].ToString();
                var address = sqldatareader["Address"].ToString();
                var city = sqldatareader["City"].ToString();
                var state = sqldatareader["State"].ToString();
                var zip = sqldatareader["Zip"].ToString();
                var phone = (sqldatareader["Phone"]).ToString();
                var email =(sqldatareader["Email"]).ToString();



                var vndr = new Vendor()
                {
                    Id = id,
                    Code = code,
                    Name = name,
                    Address = address,
                    City = city,
                    State = state,
                    Zip = zip,
                    Phone = phone,
                    Email = email
                };
                vndrs.Add(vndr);

            }
            sqldatareader.Close();
            return vndrs;




        }
        


        public User GetByPK(int id)
        {
            var sql = $"SELECT * from users where id ={id};";
            var sqlcmd = new SqlCommand(sql, sqlconn);
            var sqldatareader = sqlcmd.ExecuteReader();
            // .hasrows shows how many rows in selected column
            if(!sqldatareader.HasRows)
            {
                sqldatareader.Close();
                return null;
            }
            // .read starts before data, moves through data to process, ends right after data
            sqldatareader.Read();
            var user = new User()
            {
                Id = Convert.ToInt32(sqldatareader["Id"]),
                Password = Convert.ToString(sqldatareader["Password"]),
                Firstname = Convert.ToString(sqldatareader["Firstname"]),
                Lastname= Convert.ToString(sqldatareader["Lastname"]),
                Phone = Convert.ToString(sqldatareader["Phone"]),
                Email = Convert.ToString(sqldatareader["Email"]),
                IsReviewer = Convert.ToBoolean(sqldatareader["IsReviewer"]),
                IsAdmin = Convert.ToBoolean(sqldatareader["IsAdmin"])

            };
            sqldatareader.Close();
            return user;
        }




        //return a collection of user instances
        public List<User> GetAllUsers()
        {
            //add in SQL Statement
            var sql = "SELECT * From Users;";
            //set new instance of SqlCommand, built in method
            var sqlcmd = new SqlCommand(sql, sqlconn);
            //reader brings back results so you can read them
            var sqldatareader = sqlcmd.ExecuteReader();

            var users = new List<User>();

            //while loop executes reading the data
            while(sqldatareader.Read())
            {
                //create var for all columns
                var id = Convert.ToInt32(sqldatareader["Id"]);
                var username = Convert.ToString(sqldatareader["Username"]);
                var password = sqldatareader["Password"].ToString();
                var firstname = sqldatareader["Firstname"].ToString();
                var lastname = sqldatareader["Lastname"].ToString();
                var phone = sqldatareader["Phone"].ToString();
                var email = sqldatareader["Email"].ToString();
                var isReviewer = Convert.ToBoolean(sqldatareader["IsReviewer"]);
                var isAdmin = Convert.ToBoolean(sqldatareader["IsAdmin"]);

                //create instance of user class
                var user = new User()
                {
                    // big to small
                    Id = id, Username = username, Password = password,
                    Firstname = firstname, Lastname = lastname, Phone = phone,
                    Email = email, IsAdmin = isAdmin, IsReviewer = isReviewer
                };
                users.Add(user);
            }
            sqldatareader.Close();
            return users;
        }




        //create connect method
        public void Connect()
        {
            var connStr = "server=localhost\\sqlexpress;" +
                "database=PrsDb;" +
                "trusted_connection=true;";
            sqlconn = new SqlConnection(connStr);
            //run open method to open the connection 
            sqlconn.Open();
            //use if statement below to test connection
            if(sqlconn.State != System.Data.ConnectionState.Open)
            {
                throw new Exception("Connection string is not correct");
            }

            Console.WriteLine("Open connection Successfull");
        }

        //create disconnect method, always close connection when done
        public void Disconnect()
        {
            if (sqlconn == null)
            {
                return;
            }
            sqlconn.Close();
            sqlconn = null;
        }

       
    }
}
