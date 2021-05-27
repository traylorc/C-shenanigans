using Csharp2SQLLibrary;
using System;
using System.Linq;

namespace Csharp2SQL
{
    class Program
    {
        static int[] ints = {
            505,916,549,881,918,385,350,228,489,719,
            866,252,130,706,581,313,767,691,678,187,
            115,660,653,564,805,720,729,392,598,791,
            620,345,292,318,726,501,236,573,890,357,
            854,212,670,782,267,455,579,849,229,661,
            611,588,703,607,824,730,239,118,684,149,
            206,952,531,809,134,929,593,385,520,214,
            643,191,998,555,656,738,829,454,195,419,
            326,996,666,242,189,464,553,579,188,884,
            197,369,435,476,181,192,439,615,746,277
        };


        static void Main(string[] args)
        {
            var sum1 = (from i in ints
                        where i % 7 == 0 || i % 11 == 0
                        select i).Sum();
            var sum2 = ints.Where(i => i % 7 == 0 || i % 11 == 0).Sum();


            //method syntax
            var avg = ints.Where(x => x % 3 == 0 || x% 5 == 0 ).Average();
            //query syntax
            var avg0 = (from i in ints
                        where i % 3 == 0 || i % 5 == 0 
                        select i).Average();

            //x => equals each item in the collection like the below var i
            //x%3==0 check if each item is evenly divisible by 3'' boolean expression
            //.average() calcs average 

            var sum = 0;
            var cnt = 0;
            foreach (var i in ints)
            {
                if (i % 3 == 0)
                {
                    sum = sum + i;
                    cnt++;
                }
            }
           var avg1 = sum / cnt;




















           // var sqlconn = new Connection("localhost\\sqlexpress01", "PrsDb");


           // var newProduct = new Product()
           // {
           //     Id = 0,
           //     PartNbr = "4444",
           //     Name = "FNAF Hoodie",
           //     Price = 19.99m,
           //     Unit = "each",
           //     PhotoPath = null,
           //     VendorId = 0
           // };
           // var productsController = new ProductController(sqlconn);
           // //var success = productsController.Create(newProduct, "GME");

           // var product1 = productsController.GetByPk(3);
           //// var success = productsController.Remove(product1.Id);

           // var products = productsController.GetAllProducts();


           
            
            
           // //stuff sql connection into VendorsController and stuff that into vendorsController
           // var vendorsController = new VendorsController(sqlconn);
           // var vendors = vendorsController.GetAll();
           // var vendorId = vendorsController.GetByPk(1);
           // var vendorcode = vendorsController.GetByCode("AMZ");

           // //create new vendor
           // var newVendor = new Vendor()
           // {
           //     Id = 0,
           //     Code = "TQL",
           //     Name = "Total Quality",
           //     Address = "123 old way",
           //     City = "Cincinnati",
           //     State = "OH",
           //     Zip = "45215",
           //     Phone = "4445544332",
           //     Email = "tql@tql.com"
           // };
           // //var success = vendorsController.Create(newVendor);

           // //change vendor parameters
           // var vendor = vendorsController.GetByPk(5);
           // vendor.Email = "TQL1@tql.com";
           // /*var success = vendorsController.Change(vendor)*/;

           // //delete vendor
           // var vendor1 = vendorsController.GetByPk(5);
           // //var success = vendorsController.Remove(vendor1);








           // sqlconn.Disconnect();








             //create var name and stuff in desired class/project and call to method using new var//
            //var sqllib = new SQLLib();
            //sqllib.Connect();


           // var user = sqllib.GetByPK(6);
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




            //sqllib.Disconnect();
        }
    }
}
