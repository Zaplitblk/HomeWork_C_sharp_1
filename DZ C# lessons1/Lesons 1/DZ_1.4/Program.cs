using System;

namespace DZ_1._4
{
    class Program
    {
        //Написать программу обмена значениями двух переменных://
        //а) с использованием третьей переменной;//
        //б) *без использования третьей переменной. .,.!.!.!..невыполненно..!.!.!.,.//
        static void Wop(ref int a, ref int b)
        {
            int z = a;
            a = b;
            b = z;
        }
        static void Main(string[] args)
        {
            int a = 10;
            int b = 5;
            Console.WriteLine("А = " + a + ", В = " + b + ".");
            Wop(ref a, ref b);
            Console.WriteLine("А = " + a + ", В = " + b + ".");
            Console.ReadKey();
        }
    }
}
