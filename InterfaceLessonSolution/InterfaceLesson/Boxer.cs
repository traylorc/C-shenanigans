using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceLesson
{
    class Boxer : IPrint
    {
        public string Type { get; set; } = "Boxer";
        public string Legs { get; set; } = "Lanky";


        public void Print()
        {
            Console.WriteLine($"This dog is a {Type} and he is very {Legs}");
        }


    }
}
