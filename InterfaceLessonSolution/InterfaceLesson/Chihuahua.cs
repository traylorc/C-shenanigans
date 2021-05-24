using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceLesson
{
    class Chihuahua : IPrint
    {
        public string Characteristic { get; set; } = "Shakey";
        public string Type { get; set; } = "Chihuahua";

        public void Print()
        {
            Console.WriteLine($"This dog is a {Type} and he is {Characteristic}");
            
        }
    }
}
