using System;

namespace InterfaceLesson
{
    class Program
    {
        static void Main(string[] args)
        {
            var pb = new Pitbull();
            var ch = new Chihuahua();
            var sh = new Shiba_Inu();



            var dogs = new IPrint[] { pb, ch, sh };

            foreach(var dog in dogs)
            {
                dog.Print();
            }





        }
    }
}
