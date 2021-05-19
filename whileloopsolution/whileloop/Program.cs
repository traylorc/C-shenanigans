using System;

namespace whileloop
{
    class Program
    {
        static void Main(string[] args)
        {
            var nbr = 1;
            while(nbr <= 25)
            {
                var cubed = nbr * nbr * nbr;
                if (nbr % 2 == 1)
                {
                    Console.WriteLine($"The cube of {nbr} is {cubed}");

                }              

                nbr++;
            }
        }
    }
}
