using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceLesson
{
    class Pitbull : IPrint 
    {
        public string HeadSize { get; set; } = "Lorge";
        public string Type { get; set; } = "Pitbull";
       

        public void Print()
        {
            Console.WriteLine($"This dog is a {Type} and has a {HeadSize} head");
        }

    }
}
