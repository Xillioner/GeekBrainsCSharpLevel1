using System;
using System.Text;

namespace Lesson2_HW4
{
    public class Work
    {
        const string USERLOGIN = "Xillioner";
        const string USERPASSWORD = "12345";
        public bool IsAuthorized { get; private set; }
        private readonly string[] stringSource=new string[9] { 
        "Вы не авторизованны, завершение работы приложения!",
        "0 - Выход",
        "1 - Продолжить",
        "Вы авторизованны",
        "Расчёт индекса массы тела",
        "Введи логин",
        "Введи пароль",
        "1- Расчёт BMI",
        "Нет такого меню",
        };

        public void Authorize(string userLogin, string userPassword)
        {
            IsAuthorized = USERLOGIN == userLogin && USERPASSWORD == userPassword ? true : false;
        }

        public void Print(int[] whereToPrint, int[] stringSource = null, string message = null)
        {
            Console.Clear();
            Console.OutputEncoding = Encoding.UTF8;
            

            if (whereToPrint.Length==2)
            Console.SetCursorPosition(whereToPrint[0], whereToPrint[1]);
            Console.WriteLine(this.stringSource[4]);
            Console.WriteLine();

            if (stringSource!?.Length!=null)
            {
                for (int i = 0; i < stringSource.Length; i++)
                {
                    Console.WriteLine(this.stringSource[ stringSource[i]]);
                }
                
            }
            else if (message!=null)
            {
                Console.WriteLine(message);
            }
            else
            {
                Console.WriteLine($"\n {this.stringSource[1]}\n {this.stringSource[2]}\n");
            }

            
        }

        public void AuthorizedArea()
        {
            if (IsAuthorized)
            {
                Print(new int[] { 40, 0 }, new int[] { 7 });
                var userInput=Convert.ToInt32(Console.ReadLine());
                switch (userInput)
                {
                    case 1:

                        break;
                    default:
                        Print(new int[] { 40, 1 }, new int[8]);
                        break;
                }
            }
        }
    }
}
