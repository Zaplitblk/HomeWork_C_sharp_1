using System;

namespace DZ_1._3
{
    class Program
    {
        //а) Написать программу, которая подсчитывает расстояние между точками с координатами x1, y1 и x2,y2//
        //по формуле r=Math.Sqrt(Math.Pow(x2-x1,2)+Math.Pow(y2-y1,2).//
        //Вывести результат, используя спецификатор формата .2f (с двумя знаками после запятой);//
        //б) *Выполнить предыдущее задание, оформив вычисления расстояния между точками в виде метода.//
        static void Main(string[] args)
        {
            Console.WriteLine("Введите x1"); double x1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите y1"); double y1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите x2"); double x2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите y2"); double y2 = Convert.ToDouble(Console.ReadLine());
            Double r = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            Console.WriteLine($"x1 = {x1}, y1 = {y1}, x2 = {x2}, y2 = {y2}. r = {r}.");
            Console.WriteLine($"{r:F2}");
            Console.ReadKey();
        }
    }
}
