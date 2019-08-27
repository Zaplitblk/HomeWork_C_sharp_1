using System;

namespace DZ_2._2
{
    class Program
    {
        static void qwer(string i)
        {
            int x = i.Length;
            Console.WriteLine("Число состоит из {0} цифр", x);
            Console.ReadKey();
        }
        static void Main(string[] args)
        {
            //Написать метод подсчета количества цифр числа
            Console.WriteLine("Введите число");
            String a = Console.ReadLine();
            qwer(a);
        }
    }
}
