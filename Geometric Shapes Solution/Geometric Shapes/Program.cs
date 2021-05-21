using System;

namespace Geometric_Shapes
{
    class Program
    {
        static void Main(string[] args)
        {
            var sqr3 = new Sqr3(5);
            Console.WriteLine($"Perimeter of the Square is {sqr3.Perimeter()} and Area is {sqr3.Area()}");


            var rect3 = new Rect3(4,7);
            Console.WriteLine($"Perimeter of the Rectangle is {rect3.Perimeter()} and Area is {rect3.Area()}");

            var quad = new Quad(2, 3, 4, 5);
            Console.WriteLine($"Perimeter of the Quadrilateral is {quad.Perimeter()}");

            var x = 0;







            //var q1 = new Quad(2,3,4,5);
            //q1.Side1 = 2;
            //q1.Side2 = 3;
            //q1.Side3 = 4;
            //q1.Side4 = 5;

            //var r1 = new Rectangle();
            //r1.Rside1 = 4;
            //r1.Rside2 = 8;

            //var s1 = new Square();
            //s1.Sside1 = 10;

            //Console.WriteLine($"The perimeter of the Quadrilateral is {q1.Perimeter()}");
            //Console.WriteLine($"The perimeter of the Rectangle is {r1.RPerimeter()}");
            //Console.WriteLine($"The area of the Rectangle is {r1.RArea()}");
            //Console.WriteLine($"The perimeter of the Square is {s1.SPerimeter()}");
            //Console.WriteLine($"The area of the Square is {s1.SArea()}");


        }
    }
}
