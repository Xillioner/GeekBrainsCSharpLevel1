using System;
using System.Text;

namespace Lesson2_HW4
{
    public class Work
    {
        const string USERLOGIN = "Xillioner";
        const string USERPASSWORD = "12345";
        public bool IsAuthorized { get; private set; }
        public double? IndexBodyWeight
        {
            get
            {
                if (IsAuthorized)
                {
                    return indexBodyWeight;

                }
                return null;
            }
            private set { }
        }

        private double indexBodyWeight;
        public double extraWeight { get; private set; }

        public string IndexHelper { get { return IndexHelperInquire(); } private set { } }

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

        public void Authorize(string userLogin, string userPassword)
        {
            IsAuthorized = USERLOGIN == userLogin && USERPASSWORD == userPassword ? true : false;
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

        public void AuthorizedArea()
        {
            if (IsAuthorized)
            {
                Print(new int[] { 40, 0 }, new int[] { 7 });
                var userInput = Convert.ToInt32(Console.ReadLine());
                switch (userInput)
                {
                    case 1:
                        Print(new int[] { 40, 1 }, new int[] { 9 });
                        var weight = Convert.ToDouble(Console.ReadLine());
                        Print(new int[] { 40, 1 }, new int[] { 10 });
                        var height = Convert.ToDouble(Console.ReadLine()) / 100;
                        Bmi(weight, height);
                        ExtraWeight(height);
                        break;
                    default:
                        Print(new int[] { 40, 1 }, new int[8]);
                        break;
                }
            }
        }

        private void ExtraWeight(double height)
        {
            double normalIndexMin = 18.5;
            double normalIndexMax = 25;
            double extraIndex;

            if (IsAuthorized && indexBodyWeight > normalIndexMax)
            {
                 extraIndex = indexBodyWeight - normalIndexMax;
                extraWeight = extraIndex * Math.Pow(height, 2);
            }
            else if(IsAuthorized&&indexBodyWeight<normalIndexMin)
            {
                extraIndex = normalIndexMin-indexBodyWeight;
                extraWeight = extraIndex * Math.Pow(height, 2);
            }
        }

        private void Bmi(double weight, double height)
        {
            if (IsAuthorized)
                indexBodyWeight = weight / Math.Pow(height, 2);
        }
        private string IndexHelperInquire()
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
