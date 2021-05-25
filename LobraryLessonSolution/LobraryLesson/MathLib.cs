using System;

namespace LibraryLesson
{
    public class MathLib
    {
        //create method and return result
        public static int Add(int a, int b)
        {
            return a + b;
        }
        public static int Sub(int a, int b)
        {
            return a - b;
        }
        public static int Product(int a, int b)
        {
            return a * b;
        }
        public static int Divide(int a, int b)
        {
            return a / b;
        }
       
        public static int Modulo(int a, int b)
        {
            return a - (Product(Divide(a,b), b));
        }
    }
}
