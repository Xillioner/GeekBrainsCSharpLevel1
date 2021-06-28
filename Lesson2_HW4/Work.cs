using System;
using System.Text;

namespace Lesson2_HW4
{
    public class Work
    {
        const string USERLOGIN = "Xillioner";
        const string USERPASSWORD = "12345";

        public bool IsAuthorized { get; private set; }

        private readonly string[] stringSource = new string[21] {
        "Вы не авторизованны, завершение работы приложения!",
        "0 - Выход",
        "1 - Продолжить",
        "Вы авторизованны",
        "Расчёт индекса массы тела",
        "Введи логин",
        "Введи пароль",
        "1 - Расчёт BMI",
        "Нет такого меню",
        "Введи свой вес (кг)",
        "Введи свой рост (см)",
        "Выраженный дефицит массы тела",
        "Недостаточная (дефицит) массы тела",
        "Норма",
        "Избыточная масса тела (предожирение)",
        "Ожирение 1 степени",
        "Ожирение 2 степени",
        "Ожирение 3 степени",
        " - вам следует набрать",
        " - вам следует похудеть на",
        "1 - Логин",
        };

        public void Authorize(User user)
        {
            IsAuthorized = USERLOGIN == user.UserLogin && USERPASSWORD == user.UserPassword ? true : false;
        }

        public void Print(int[] whereToPrint, int[] stringSource = null, string message = null)
        {
            Console.Clear();
            Console.OutputEncoding = Encoding.UTF8;

            if (whereToPrint.Length == 2)
                Console.SetCursorPosition(whereToPrint[0], whereToPrint[1]);
            Console.WriteLine(this.stringSource[4]);
            Console.WriteLine();

            if (stringSource!?.Length != null)
            {
                for (int i = 0; i < stringSource.Length; i++)
                {
                    Console.WriteLine(this.stringSource[stringSource[i]]);
                }
            }
            else if (message != null)
            {
                Console.WriteLine(message);
            }
            else
            {
                Console.WriteLine($"\n {this.stringSource[1]}\n {this.stringSource[20]}\n");
            }
        }

        public void AuthorizedArea(User user, int userInput)
        {
            var height = user.Height / 100;
            if (IsAuthorized)
            {
                switch (userInput)
                {
                    case 1:
                        user.IndexBodyWeight = Bmi(user.Weight, height);
                        user.ExtraWeight = ExtraWeight(height, user.IndexBodyWeight);
                        user.IndexHelper = IndexHelperInquire(user.IndexBodyWeight);
                        break;
                    default:
                        Print(new int[] { 40, 1 }, new int[8]);
                        break;
                }
            }
        }

        private double ExtraWeight(double height, double indexBodyWeight)
        {
            double normalIndexMin = 18.5;
            double normalIndexMax = 25;
            double extraIndex;

            if (IsAuthorized && indexBodyWeight > normalIndexMax)
            {
                extraIndex = indexBodyWeight - normalIndexMax;
                return extraIndex * Math.Pow(height, 2);
            }
            else if (IsAuthorized && indexBodyWeight < normalIndexMin)
            {
                extraIndex = normalIndexMin - indexBodyWeight;
                return extraIndex * Math.Pow(height, 2);
            }
            return 0;
        }

        private double Bmi(double weight, double height)
        {
            if (IsAuthorized)
                return weight / Math.Pow(height, 2);
            return 0;
        }

        private string IndexHelperInquire(double indexBodyWeight)
        {
            if (IsAuthorized && indexBodyWeight < 17)
            {
                return stringSource[11] + stringSource[18];
            }
            else if (indexBodyWeight < 18.5)
            {
                return stringSource[12] + stringSource[18];
            }
            else if (indexBodyWeight < 25)
            {
                return stringSource[13];
            }
            else if (indexBodyWeight < 30)
            {
                return stringSource[14] + stringSource[19];
            }
            else if (indexBodyWeight < 35)
            {
                return stringSource[15] + stringSource[19];
            }
            else if (indexBodyWeight < 40)
            {
                return stringSource[16] + stringSource[19];
            }
            else
            {
                return stringSource[17] + stringSource[19];
            }
        }
    }
}
