using System;
using System.Collections.Generic;
using System.Text;

namespace EtensionMethodsLesson
{
    static class MyExtensionMethods
    {
        //this var type and var name
        public static string ToUpperCase(this string s)
        {
            return s.ToUpper();
        }
        public static void ToConsole(this string str)
        {
            Console.WriteLine($"{str}");
        }
    }
}
