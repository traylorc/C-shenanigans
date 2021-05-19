using System;

namespace nightpractice2
{
    class Program
    {
        static void Main(string[] args)
        {
            for ( var idx = 1; idx <=100; idx++)
            {
                if(idx % 7 == 0 && idx % 11 == 0)
                    Console.WriteLine("Totodile");
                else if(idx % 7 !=0 && idx % 11== 0)
                    Console.WriteLine("Dile");
                else if(idx % 7 == 0 && idx % 11 !=0)
                    Console.WriteLine("Toto");
                else
                    Console.WriteLine($"{idx}");
            }
        }
    }
}
