using System;

namespace DZ_2._1
{
    class Program
    {
        //Написать метод, возвращающий минимальное из трёх чисел//
        static void qwer(double i)
        {
            Console.WriteLine("Минимальное число =" + i);
            Console.ReadKey();
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число 1");
            Double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите число 2");
            Double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите число 3");
            Double c = Convert.ToDouble(Console.ReadLine());
            double min = 0;
            if (a < b & a < c)
            {
                min = a;
            }
            else if (b < c)
            {
                min = b;
            }
            else
            {
                min = c;
            }
            qwer(min);
        }
    }
}
