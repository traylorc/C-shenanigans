using System;
using System.Collections.Generic;
using System.Text;

namespace classtutorial
{
    class TQLMath
    {

        public TQLMath(int a, int B)
        {
            A = a;
           this.B = B;
        }

        public int A { get; set; }
        public int B { get; set; }
        public int C { get; set; }
        public int D { get; set; }


        public int Sum()
        {
            return A + B;
        }
        public int Sub()
        {
            return C - D;
        }
    }
}
