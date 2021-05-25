using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceLesson
{
    class Collie : IPrint
    {
        public string Type { get; set; } = "Collie";
        public string Bark { get; set; } = "Aarf";

        public void Print()
        {      
    {       
           Console.WriteLine($"This dog is a {Type} and sounds like {Bark}");
    }
        }
    }

}
