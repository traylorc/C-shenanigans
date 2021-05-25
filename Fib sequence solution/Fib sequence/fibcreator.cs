using System;
using System.Collections.Generic;
using System.Text;

namespace Fib_sequence
{
    public class fibcreator
    {
        //start method, method static can only access other static methods, best use is when you dont have any properties to pass in
        public static List <int> GenerateSequence(int last = 200)
        {
            //create a var name for your list and add parens for a value
            var fibs = new List<int>();
            //create var 'a' and add it to the list
            var a = 0;
            fibs.Add(a);
            //creat var 'b' and add it to the list
            var b = 1;
            fibs.Add(b);
            //set initial value for 'c'
            int c = 0;
            //while 'c' is lower than the last number in the sequence(200)
            while(c< last)
            {
                // 'c' equals 'a' + 'b', add the new 'c' to the list
                c = a + b;
                fibs.Add(c);
                //old 'b' becomes new 'a', 'c' becomes new 'b', rinse and repeat till reaches(200)
                a = b;
                b = c;
            }
            // return list
            return fibs;
        }
    }
}
