using System;

namespace nightpractice3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nbrs = 
            {
               234, 444, 567, 247, 987, 675, 174, 498,
               964, 287, 479, 279, 947, 589, 578, 398,
               378, 298, 575, 222, 788, 777, 932, 576
            };
            var highest = 0;
            var lowest = 1000;
            var total = 0;
            var count = 0;

            foreach(var nbr in nbrs)
            {
                if (nbr > highest)
                    highest = nbr;
                if (nbr < lowest)
                    lowest = nbr;
                total = total + nbr;
                    count++;
            }
            Console.WriteLine($"Highest number is {highest} and lowest number is {lowest}");
            Console.WriteLine($"The average of the {count} is {total / count}");

           
        }
    }
}
