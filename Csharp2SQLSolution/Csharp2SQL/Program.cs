using Csharp2SQLLibrary;
using System;

namespace Csharp2SQL
{
    class Program
    {
        static void Main(string[] args)
        {

            var sqlconn = new Connection("localhost\\sqlexpress", "PrsDb");


            var newProduct = new Product()
            {
                Id = 0,
                PartNbr = "Ball",
                Name = "Basket",
                Price = 20,
                Unit = "Each",
                PhotoPath = null,
                VendorId = 0
            };
            var productsController = new ProductController(sqlconn);
           // var success = productsController.Create(newProduct, "AMZ");

            var product1 = productsController.GetByPk(4);
            //var success = productsController.Remove(product1);

            var products = productsController.GetAllProducts();


           
            
            
            //stuff sql connection into VendorsController and stuff that into vendorsController
            var vendorsController = new VendorsController(sqlconn);
            var vendors = vendorsController.GetAll();
            var vendorId = vendorsController.GetByPk(1);
            var vendorcode = vendorsController.GetByCode("AMZ");

            //create new vendor
            var newVendor = new Vendor()
            {
                Id = 0,
                Code = "TQL",
                Name = "Total Quality",
                Address = "123 old way",
                City = "Cincinnati",
                State = "OH",
                Zip = "45215",
                Phone = "4445544332",
                Email = "tql@tql.com"
            };
            //var success = vendorsController.Create(newVendor);

            //change vendor parameters
            var vendor = vendorsController.GetByPk(5);
            vendor.Email = "TQL1@tql.com";
            /*var success = vendorsController.Change(vendor)*/;

            //delete vendor
            var vendor1 = vendorsController.GetByPk(5);
            //var success = vendorsController.Remove(vendor1);








            sqlconn.Disconnect();








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
