using System;

namespace Geometric_Shapes
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var sqr35 = new Sqr3(5);
            var sqr37 = new Sqr3(7);
            var rect31 = new Rect3(4, 7);
            var rect32 = new Rect3(3, 5);
            var rect33 = new Rect3(9, 11);
            var quad10 = new Quad(1, 2, 3, 4);

            var shapes = new Quad[] { sqr35, sqr37, rect31, rect32, rect33, quad10 };

            foreach(var shape in shapes)
            {
                Console.WriteLine($"{shape.WhatAmI()} perimeter is {shape.Perimeter()}");
            }
            
            
            
            
            
            
            
            
            var sqr3 = new Sqr3(5);
            

            var rect3 = new Rect3(4,7);
            
            var quad = new Quad(2, 3, 4, 5);
            

           
            
            
            
            
            
            
            
            
            
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
