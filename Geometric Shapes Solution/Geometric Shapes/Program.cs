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

            var r1 = new Rectangle();
            r1.Rside1 = 4;
            r1.Rside2 = 8;

            var s1 = new Square();
            s1.Sside1 = 10;

            Console.WriteLine($"The perimeter of the Quadrilateral is {q1.Perimeter()}");
            Console.WriteLine($"The perimeter of the Rectangle is {r1.RPerimeter()}");
            Console.WriteLine($"The area of the Rectangle is {r1.RArea()}");
            Console.WriteLine($"The perimeter of the Square is {s1.SPerimeter()}");
            Console.WriteLine($"The area of the Square is {s1.SArea()}");


        }
    }
}
