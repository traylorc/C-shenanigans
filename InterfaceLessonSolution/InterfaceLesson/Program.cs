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
            var bo = new Boxer();
            var co = new Collie();



            var dogs = new IPrint[] { pb, ch, sh, bo, co};

            foreach(var dog in dogs)
            {
                dog.Print(); 
            }





        }
    }
}
