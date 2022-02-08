using System;

namespace Module3
{
    class Program
    {
        static void Main(string[] args)
        {
            //    const string MyName = "Владимир";
            //    const byte MyAge = 30;
            //    const bool Pet = false;
            //    const double Size = 42.5;
            //    Console.WriteLine("Меня зовут {0}", MyName);
            //    Console.WriteLine("Мне {0} лет", MyAge);
            //    Console.WriteLine("У вас есть домашнее животное? {0}", Pet);
            //    Console.WriteLine("Мой размер обуви {0}", Size);
            //    Console.WriteLine("IntMin {0} ", int.MinValue);
            //    Console.WriteLine("IntMax {0} ", int.MaxValue);
            //    Console.WriteLine("DoubleMin {0} ", double.MinValue);
            //    Console.WriteLine("DoubleMax {0} ", double.MaxValue);
            //    Console.ReadKey();
            //}
            //enum DaysOfWeek : byte
            //{
            //    Monday = 1,
            //    Tuesday,
            //    Wednesday,
            //    Thursday,
            //    Friday,
            //    Saturday,
            //    Sunday
            //}
            //enum Semaphore
            //{
            //    Red = 100,
            //    Yellow = 200,
            //    Green = 300
            //}

            //    string MyName = "Computer";
            //    Console.WriteLine("Привет, человек");
            //    Console.WriteLine("Меня зовут {0}", MyName);
            //    Console.Write("А как тебя зовут? ");
            //    string YourName = Console.ReadLine();
            //    Console.Write("Рад встрече, {0} ", YourName);
            //    Console.ReadKey();
            //}

            //    double five = 5;
            //    double two = 2;
            //    double result = five / two;
            //    Console.WriteLine("5 / 2 = {0}", result);
            //    Console.ReadKey();
            //    double result = 5.0 / 2.0;
            //    Console.WriteLine("5 / 2 = {0}", result);
            //    Console.ReadKey();

            //double result = 10 % 3;
            //Console.Write("10 % 3 = {0} ", result);
            //Console.ReadKey();

            //Console.Write("Введите свой возраст: ");
            //int age = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Ваш возраст {0} ", age);
            //Console.ReadKey();

            //Console.Write("Введите свой возраст: ");
            //int age;
            //bool iscorrect = int.TryParse(Console.ReadLine(), out age);
            //Console.WriteLine("Ваш возраст {0} ", age);
            //Console.ReadKey();

            //var age = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите свое имя: ");
            string name = Console.ReadLine();
            Console.Write("Введите свой возраст: ");
            var age = int.Parse(Console.ReadLine());
            Console.WriteLine("Ваше имя {0} и Ваш возраст {1}.", name, age);
            //Console.Write("Введите любимый день недели: ");
            //var day = (DaysOfWeek) int.Parse(Console.ReadLine());
            Console.Write("Введите дату вашего рождения: ");
            var birthdate = Console.ReadLine();
            Console.WriteLine("Дата вашего рождения {0}.", birthdate);
            Console.ReadKey();
        }
            enum DaysOfWeek : byte
            {
            Понедельник = 1,
            Вторник,
            Среда,
            Четверг,
            Пятница,
            Суббота,
            Воскресенье
            }
    }
}
