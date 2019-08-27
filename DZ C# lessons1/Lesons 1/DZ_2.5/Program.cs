using System;

namespace DZ_2._5
{
    class Program
    {

        //а) Написать программу, которая запрашивает массу и рост человека, вычисляет его индекс массы//
        //и сообщает, нужно ли человеку похудеть, набрать вес или всё в норме.//
        //б) *Рассчитать, на сколько кг похудеть или сколько кг набрать для нормализации веса.//
        static void Main(string[] args)
        {
            Double standart = 21;
            Console.WriteLine("Введите ваш вес: ");
            Double w = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите ваш рост в метрах: ");
            Double h = Convert.ToDouble(Console.ReadLine());
            Double x = w / Math.Pow(h, h);
            Console.WriteLine(x);

            if (x > standart + 3)
            {
                double q = (x - standart - 3) * Math.Pow(h, h);
                Console.WriteLine("Ваш индекс тела слишком большой. У вас избыточный вес.\nСбросьте {0} кг.", q);
            }
            else if (x < standart - 3)
            {
                double q = (standart - x) * Math.Pow(h, h);
                Console.WriteLine("Ваш индекс тела слишком мал. У вас нехватка веса.\nНаберите {0} кг.", q);
            }
            else
            {
                Console.WriteLine("Ваш индекс тела в норме, так держать");
            }
            Console.ReadKey();
        }
    }
}
