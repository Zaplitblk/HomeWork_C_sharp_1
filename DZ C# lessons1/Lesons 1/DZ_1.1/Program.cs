using System;

namespace DZ_1._1
{
    class Program
    {
        // Написать программу «Анкета». Последовательно задаются вопросы (имя, фамилия, возраст, рост, вес).//
        //В результате вся информация выводится в одну строчку://
        //а) используя склеивание;//
        //б) используя форматированный вывод;//
        //в) используя вывод со знаком $.//
        static void Main(string[] args)
        {
            Console.WriteLine("Введите Имя ");
            string fName = Console.ReadLine();
            Console.WriteLine("Введите Фамилию");
            string sName = Console.ReadLine();
            Console.WriteLine("Введите возраст");
            string age = Console.ReadLine();
            Console.WriteLine("Введите рост в сантиметрах");
            string h = Console.ReadLine();
            Console.WriteLine("Введите вес в килограмах ");
            string w = Console.ReadLine();
            Console.WriteLine("Имя " + fName + ", Фамилия " + sName + ", возраст " + age + ", рост " + h + ", вес " + w + ".");
            Console.WriteLine($"Имя {fName}, Фамилия {sName}, возраст {age}, рост {h}, вес {w}.");
            Console.WriteLine("Имя {0}, Фамилия {1}, возраст {2}, рост {3}, вес {4}.", fName, sName, age, h, w);
            Console.ReadKey();
        }
    }
}
