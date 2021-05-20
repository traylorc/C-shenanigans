using System;

namespace Geometric_Shapes
{
    class Program
    {
        static void Main(string[] args)
        {
            var q1 = new Quad();
            q1.Side1 = 2;
            q1.Side2 = 3;
            q1.Side3 = 4;
            q1.Side4 = 5;

            Console.WriteLine($"The perimeter of the Quadrilateral is {q1.Perimeter()}");

           

        }
    }
}
