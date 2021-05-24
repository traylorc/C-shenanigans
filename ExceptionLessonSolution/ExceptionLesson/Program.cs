using System;

namespace ExceptionLesson
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
            Level1();
            }
            catch(DivideByZeroException ex)
            {
                Console.WriteLine($"Exception handled in Level1: {ex.Message}");
            }
        }

        static void Level1()
        {
            Level2();
        }
        static void Level2()
        {
            Level3();
        }
        static void Level3()
        {
            var n = 1;
            var d = 0;
            var e = n / d;
        }
        
       

    }
}
