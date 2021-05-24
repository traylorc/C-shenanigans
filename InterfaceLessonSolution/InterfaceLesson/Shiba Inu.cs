using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceLesson
{
    class Shiba_Inu : IPrint
    {
        public string Characteristic { get; set; } = "Stand-Offish";
        public string Type { get; set; } = "Shiba Inu";

        public void Print()
        {
            Console.WriteLine($"This dog is a {Type} and he is {Characteristic}");
            
        }
    }
}
