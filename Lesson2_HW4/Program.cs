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
        private static User user;

        static void Main(string[] args)
        {
            work = new();
            user = new();
            //string userLogin = null;
            //string userPassword = null;
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
                                user.UserLogin = Console.ReadLine();
                                work.Print(new int[] { 40, 0 }, new int[] { 6 });
                                user.UserPassword = Console.ReadLine();
                                work.Authorize(user);
                            }
                            if (!work.IsAuthorized)
                                count--;
                            else break;
                        }

                        if (work.IsAuthorized)
                        {
                            AuthorizedMessage();

                            work.Print(new int[] { 40, 0 }, new int[] { 7 });
                            var userInput = Convert.ToInt32(Console.ReadLine());

                            work.Print(new int[] { 40, 1 }, new int[] { 9 });
                            user.Weight = Convert.ToDouble(Console.ReadLine());
                            work.Print(new int[] { 40, 1 }, new int[] { 10 });
                            user.Height = Convert.ToDouble(Console.ReadLine());

                            work.AuthorizedArea(user, userInput);
                            string extraWeight = user.ExtraWeight == 0 ? "" : $"{user.ExtraWeight:F1} Кг";
                            work.Print(new int[] { 40, 1 }, null, $"BMI - {user.IndexBodyWeight:F1} - {user.IndexHelper} {extraWeight}\n1 - Продолжить");
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

        private static void AuthorizedMessage()
        {
            work.Print(new int[] { 40, 0 }, new int[] { 3, 2 });
            Console.ReadKey();
        }
    }
}
