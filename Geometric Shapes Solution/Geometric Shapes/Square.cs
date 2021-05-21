using System;
using System.Collections.Generic;
using System.Text;

namespace Geometric_Shapes
{
    class Square
    {
        public int Sside1 { get; set; }

        public int SPerimeter()
        {
            return Sside1 * 4;
        }
        public int SArea()
        {
            return Sside1 * Sside1;
        }

    }
}
