using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;

namespace Csharp2SQLLibrary
{
    public class SQLLib
    {
        //set property for connection
        public SqlConnection sqlconn { get; set; }

        //return a collection of user instances
        public List<User> GetAllUsers()
        {
            //add in SQL Statement
            var sql = "SELECT * From Users;";
            //set new instance of SqlCommand
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
                    Id = id, Username = username, Password = password,
                    Firstname = firstname, Lastname = lastname, Phone = phone,
                    Email = email, IsAdmin = isAdmin, IsReviewer = isReviewer
                };
                users.Add(user);
            }
            return users;
        }

        //create connect method
        public void Connect()
        {
            var connStr = "server=localhost\\sqlexpress;" +
                "database=PrsDb;" +
                "trusted_connection=true;";
            sqlconn = new SqlConnection(connStr);
            sqlconn.Open();
            if(sqlconn.State != System.Data.ConnectionState.Open)
            {
                throw new Exception("Connection string is not correct");
            }

            Console.WriteLine("Open connection Successfull");
        }

        //create disconnect method
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
