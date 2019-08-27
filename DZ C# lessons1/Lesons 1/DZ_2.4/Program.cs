using System;

namespace DZ_2._4
{
    class Program
    {
        //Реализовать метод проверки логина и пароля.//
        //На вход метода подается логин и пароль.На выходе истина, если прошел авторизацию,//
        //и ложь, если не прошел(Логин: root, Password: GeekBrains).//
        //Используя метод проверки логина и пароля, написать программу://
        //пользователь вводит логин и пароль, программа пропускает его дальше или не пропускает.//
        //С помощью цикла do while ограничить ввод пароля тремя попытками.//

        static bool Check(string l, string p)
        {

            if (l == "root" && p == "GeekBrains")
                return true;
            else
                return false;
        }
        static void Main(string[] args)
        {
            for (int i = 1; i <= 3; i++)
            {
                Console.WriteLine("Введите ваш Login (root): ");
                string login = Console.ReadLine();
                Console.WriteLine("Введите ваш Password (root): ");
                string password = Console.ReadLine();
                if (Check(login, password))
                {
                    Console.WriteLine("Авторизация успешно пройдена");
                    Console.ReadKey();
                    break;
                }
                else
                {
                    Console.WriteLine("Проверьте логин и параль, попробуйте повторить");
                    Console.ReadKey();
                }
            }
        }
    }
}
