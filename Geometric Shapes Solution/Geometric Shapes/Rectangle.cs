using System;
using System.Collections.Generic;
using System.Text;

namespace Geometric_Shapes
{
    class Rectangle
    {
        public int Rside1 { get; set; }
        public int Rside2 { get; set; }


        public int RPerimeter()
        {
            return (Rside1 * 2) + (Rside2 * 2);
        }
        public int RArea()
        {
            return Rside1 * Rside2;
        }
        
        
    }
}
