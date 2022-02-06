using System;

namespace Module3
{
    class Program
    {
        static void Main(string[] args)
        {
            const string MyName = "Владимир";

            Console.WriteLine(MyName);

            Console.WriteLine("\tПривет, мир");
            Console.WriteLine("\tМне 30 лет");
            Console.WriteLine("\tМое имя \n Владимир");
            Console.WriteLine("\u0040");
            Console.WriteLine("\u0023");
            Console.WriteLine("\x40");
            Console.WriteLine("\x23");

            Console.ReadKey();
        }
    }
}
