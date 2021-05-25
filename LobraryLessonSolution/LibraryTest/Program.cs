using LibraryLesson;
using System;

namespace LibraryTest
{
    class Program
    {
        static void Main(string[] args)
        {
           //remember static lets us do the below without creating and instance for 'Mathlib', we can directly reference it
            var oneplustwo = MathLib.Add(1, 2);
            var sevenminustwo = MathLib.Sub(7, 2);
            var twoxtwo = MathLib.Product(2, 2);
            var tendividetwo = MathLib.Divide(10, 2);
            var twelvemodulothree = MathLib.Modulo(12, 3);
        }
    }
}
