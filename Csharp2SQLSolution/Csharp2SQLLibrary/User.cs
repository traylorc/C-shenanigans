using System;
using System.Collections.Generic;
using System.Text;

namespace Csharp2SQLLibrary
{
    public class User
    {
        //add properties of table you are trying to reach
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public bool IsReviewer { get; set; }
        public bool IsAdmin { get; set; }

    }
}
