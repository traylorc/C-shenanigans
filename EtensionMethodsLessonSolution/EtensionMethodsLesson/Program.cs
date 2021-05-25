using System;

namespace EtensionMethodsLesson
{
    class Program
    {
        static void Main(string[] args)
        {
            //call to ToConsole class extension
            var abc = "Sorry for the delay, we are trying so hard but are not equipped for this pressure";
            abc.ToUpper().ToConsole();
        }
    }
}
