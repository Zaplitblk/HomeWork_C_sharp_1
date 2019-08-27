using System;

namespace DZ_1._2
{
    class Program
    {
        //вести вес и рост человека.//
        //Рассчитать и вывести индекс массы тела (ИМТ) по формуле I=m/(h*h);//
        //где m — масса тела в килограммах, h — рост в метрах.//
        static void Main(string[] args)
        {
            Console.WriteLine("Введите рост в метрах (через запятую)");
            double h = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите вес в килограмах ");
            double w = Convert.ToDouble(Console.ReadLine());
            double s = h * h;
            double i = w % s;
            Console.WriteLine($"Введенный рост {h}м. и вес {w}кг. соответствует индексу массы тела равоного {i}");
            Console.ReadKey();
        }
    }
}
