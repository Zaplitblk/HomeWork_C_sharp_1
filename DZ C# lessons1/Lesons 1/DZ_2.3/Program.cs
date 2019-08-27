using System;

namespace DZ_2._3
{
    class Program
    {
        //С клавиатуры вводятся числа, пока не будет введен 0.//
        //Подсчитать сумму всех нечётных положительных чисел.//

        //static void celoe()//
        //{//
        //    int a = 20;//
        //    int q = a;//
        //    do//
        //    {//
        //        q = q/2;//
        //    }//
        //    while ()//
        //}//


        static void Main(string[] args)
        {
            
            int s = 0;
            bool z = true;
            do
            {
                Console.Write("\nВведите число\n");
                int x = Convert.ToInt32(Console.ReadLine());
                if (x == 0)
                {
                    z = false;
                    Console.Write("Вы ввели цифру 0. Программа завершена.\nВы ввели нечётных положительных чисел в сумме = " + s);
                    Console.ReadKey();
                    return;
                }
                else
                {
                    if (x % 2 == 0)
                    {
                        s = s + x;
                    }
                }
            }
            while (z == true);

        }
    }
}
