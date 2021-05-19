using System;

namespace classtutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            var tqlmath = new TQLMath();
            tqlmath.A = 21;
            tqlmath.B = 30;
            tqlmath.C = 50;
            tqlmath.D = 47;
            var sum = tqlmath.Sum();
            var sub = tqlmath.Sub();
            Console.WriteLine($"Sum of {tqlmath.A} and {tqlmath.B} is {sum}");
            Console.WriteLine($"Result of {tqlmath.C} minus {tqlmath.D} is {sub}");
        }
    }
}
