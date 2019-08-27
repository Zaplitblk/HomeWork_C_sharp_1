using System;

namespace DZ_2._7
{
    class Program
    {
        //a) Разработать рекурсивный метод, который выводит на экран числа от a до b(a<b).//
        static void Main(string[] args)
        {
            
            static void Try(int z, int x)
            {
                if (z <= x)
                {
                    Console.WriteLine(z);
                    Try(z + 1, x);
                }
            }
            static void Main(string[] args)
            {
                Console.WriteLine("Введите число А: ");
                int a = (Convert.ToInt32(Console.ReadLine()));
                Console.WriteLine("Введите число B: ");
                int b = (Convert.ToInt32(Console.ReadLine()));
                Try(a, b);
                Console.ReadKey();
            }
        }
    }
}
