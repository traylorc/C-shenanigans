using System;
using System.Collections.Generic;
using System.Text;

namespace Geometric_Shapes
{
    class Rect3 : Quad
    {
        public Rect3(int s1, int s2) : base(s1, s2, s1, s2)
        {
            
        }

        public override string WhatAmI()
        {
            return "Rect3";
        }

        public int Area()
        {
            return Side1 * Side2;
        }
    }
}
