using System;

namespace Lesson2_HW4
{
    /// <summary>
    /// Реализовать метод проверки логина и пароля. 
    /// На вход подается логин и пароль. 
    /// На выходе истина, если прошел авторизацию, и ложь, если не прошел. 
    /// Используя метод проверки логина и пароля, написать программу: 
    /// пользователь вводит логин и пароль, программа пропускает его дальше или не пропускает. 
    /// С помощью цикла do while ограничить ввод пароля тремя попытками; 
    /// а) Написать программу, которая запрашивает массу и рост человека, 
    /// вычисляет его индекс массы и сообщает, нужно ли человеку похудеть, 
    /// набрать вес или все в норме; 
    /// б) *Рассчитать, на сколько кг похудеть или сколько кг набрать для нормализации веса.
    /// </summary>
    class Programs
    {
        private static Work work;
        static void Main(string[] args)
        {
            work = new();

            string userLogin = null;
            string userPassword = null;
            work.Print(new int[] { 40, 0 });
            var menuStep = 0;
            do
            {
                work.Print(new int[] { 40, 1 });
                menuStep = Convert.ToInt32(Console.ReadLine());
                switch (menuStep)
                {
                    case 0:
                        Environment.Exit(0);
                        break;
                    case 1:
                        int count = 3;
                        while (count > 0)
                        {
                            if (!work.IsAuthorized)
                            {
                                work.Print(new int[] { 40, 0 }, new int[] { 5 });
                                userLogin = Console.ReadLine();
                                work.Print(new int[] { 40, 0 }, new int[] { 6 });
                                userPassword = Console.ReadLine();
                                work.Authorize(userLogin, userPassword);
                            }
                            if (!work.IsAuthorized)
                                count--;
                            else break;
                        }

                        if (work.IsAuthorized)
                        {
                            Authorized();
                            work.AuthorizedArea();
                            string extraWeight = work.extraWeight == 0 ? "" : $"{work.extraWeight:F1} Кг";
                            work.Print(new int[] { 40, 1 }, null, $"{work.IndexBodyWeight} - {work.IndexHelper} {extraWeight}\n1 - Продолжить");
                            Console.ReadKey();
                        }
                        else
                        {
                            work.Print(new int[] { 0, 2 }, new int[] { 4 });
                        }
                        break;
                    default:
                        work.Print(new int[] { 40, 1 });
                        break;
                }
            } while (menuStep != 0);
        }
        private static void Authorized()
        {
            work.Print(new int[] { 40, 0 }, new int[] { 3, 2 });
            Console.ReadKey();

        }
    }
}
