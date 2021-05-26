using Csharp2SQLLibrary;
using System;

namespace Csharp2SQL
{
    class Program
    {
        static void Main(string[] args)
        {
             //create var name and stuff in desired class/project and call to method using new var//
            var sqllib = new SQLLib();
            sqllib.Connect();


            //var user = sqllib.GetByPK(6);
            //var success = sqllib.Remove(user);


            //var user = sqllib.GetByPK(6);
            //user.Phone = "3334445678";
            //var success = sqllib.Change(user);



            //set var for the new user//
            //var newuser = new User()
            //{
            //    //add in values for required fields
            //    Id = 0, Username = "Barkboi1", Password = "Aarf", Firstname = "Dog", Lastname = "Boi",
            //    Phone = "888", Email = "yeet", IsReviewer = true, IsAdmin = true 
            //};
            // create var for data to feed into, call desired method //
            //var success = sqllib.Create(newuser);




            //var users = sqllib.GetAllUsers();
            //var vndrs = sqllib.GetAllVendors();




            sqllib.Disconnect();
        }
    }
}
