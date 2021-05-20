using System;

namespace sendhelpAMonOwn
{
    class Program
    {
        static void Main(string[] args)
        {
            var c1 = new Customers("Amazon", "Stockton", "CA");
            var c2 = new Customers("Staples", "Tracy", "CA");
            var c3 = new Customers("GameStop", "Hayward", "CA");

            c1.AddSales(1000);
            c1.AddSales(3800);
            Console.WriteLine($"Customer {c1.Name} sales is {c1.Sales}");
        }
    }
}
