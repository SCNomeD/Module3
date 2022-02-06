using System;

namespace Module3
{
    class Program
    {
        static void Main(string[] args)
        {
            const string MyName = "Владимир";
            const byte MyAge = 30;
            const bool Pet = false;
            const double Size = 42.5;

            Console.WriteLine("Меня зовут {0}", MyName);
            Console.WriteLine("Мне {0} лет", MyAge);
            Console.WriteLine("У вас есть домашнее животное? {0}", Pet);
            Console.WriteLine("Мой размер обуви {0}", Size);

            Console.WriteLine("IntMin {0} ", int.MinValue);
            Console.WriteLine("IntMax {0} ", int.MaxValue);
            Console.WriteLine("DoubleMin {0} ", double.MinValue);
            Console.WriteLine("DoubleMax {0} ", double.MaxValue);

            Console.ReadKey();
        }
    }

}
