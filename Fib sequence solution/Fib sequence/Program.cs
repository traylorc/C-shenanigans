using System;
using System.Collections.Generic;
namespace Fib_sequence
{
    class Program
    {
        static void Main(string[] args)
        {
            // connect in the method from fibcreator into method
            List<int> fibs = fibcreator.GenerateSequence(200);
            //set initial value for the sum of the numbers
            var sum = 0;
            // for each number(fib) in the list of numbers(fibs)
            foreach(var fib in fibs)
            {
                //add number fib to previous sum to get new sum
                sum = sum + fib;
            }
            //average is the sum of the numbers divided by the quantity of numbers in the list
            var avg = sum / fibs.Count;
            Console.WriteLine($"Fibs avg is {avg}");
        

        }
    }
}
