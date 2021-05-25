using Csharp2SQLLibrary;
using System;

namespace Csharp2SQL
{
    class Program
    {
        static void Main(string[] args)
        {


             //create var name and call to method
            var sqllib = new SQLLib();
            sqllib.Connect();




            var users = sqllib.GetAllUsers();
            var user = sqllib.GetByPK(1);
            var vndrs = sqllib.GetAllVendors();




            sqllib.Disconnect();
        }
    }
}
