using System;
using System.Collections.Generic;
using System.Text;

namespace Geometric_Shapes
{
    class Sqr3 : Rect3
    {
        public Sqr3(int s) : base(s, s)
        { }

        public override string WhatAmI()
        {
            return "Sqr3";
        }
    }
}
