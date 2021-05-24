using System;
using System.Collections.Generic;

namespace GenericCollectionsLesson
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            var ints = new List<int>();

            for(var idx = 0; idx <10; idx++)
            {
                var score = rnd.Next(0, 31);
                ints.Add(score);
            }

            var total = 0;
            foreach(var i in ints)
            {
                total = total + i;
            }
            Console.WriteLine($"Total is {total}");



























            //var ints = new List<int>();
            //ints.Add(4);
            //ints.Add(7);
            //ints.Add(15);
            //Console.WriteLine($"The ints have {ints.Count} items");
            //ints.Remove(7);
            //Console.WriteLine($"The ints have {ints.Count} items");
        }
    }
}
