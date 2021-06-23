using System;
using System.Text;

namespace Lesson1_HW3
{
    /// <summary>
    /// 3. Написать программу обмена значениями двух переменных
    /// а) с использованием третьей переменной;
    /// б) * без использования третьей переменной.
    /// а) Написать программу, которая выводит на экран ваше имя, фамилию и город проживания.
    /// б) * Сделайте задание, только вывод организуйте в центре экрана
    /// в) * Сделайте задание б с использованием собственных методов(например, Print(string ms, int x, int y)
    /// </summary>
    class Program
    {

        static void Main(string[] args)
        {
            HomeWork3 homeWork3 = new()
            {
                ObjVariable1 = "Hello",
                ObjVariable2 = "World",
                Variable1 = 17,
                Variable2 = 4
            };


            Console.OutputEncoding = Encoding.UTF8;
            Console.SetCursorPosition(40, 1);
            Console.WriteLine("Программа обмена значениями двух переменных\n");
            #region а) с использованием третьей переменной;
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("C использованием третьей переменной\n");

            Console.WriteLine($"Начальные значения: \"{homeWork3.Variable1}\", \"{homeWork3.Variable2}\", \"{homeWork3.Variable3}\"");

            homeWork3.ChangeThreeVariables();


            Console.WriteLine($"Конечные значения: \"{homeWork3.Variable1}\", \"{homeWork3.Variable2}\", \"{homeWork3.Variable3}\"\n\n");
            Console.ReadKey();
            #endregion

            #region б) * без использования третьей переменной.
            Console.WriteLine("Без использования третьей переменной\n");
            Console.WriteLine($"Начальные значения: \"{homeWork3.ObjVariable1}\", \"{homeWork3.ObjVariable2}\"");
            homeWork3.ChangeTwoVariables();
            Console.WriteLine($"Конечные значения: \"{homeWork3.ObjVariable1}\", \"{homeWork3.ObjVariable2}\"");
            Console.ReadKey();
            #endregion

            #region а) Написать программу, которая выводит на экран ваше имя, фамилию и город проживания.
            Console.Clear();
            Console.OutputEncoding = Encoding.UTF8;
            Console.SetCursorPosition(40, 1);
            Console.WriteLine("Приграмма выводит на экран имя, фамилию и город проживания");
            Console.WriteLine("Введи своё имя");
            homeWork3.FirstName = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Введи свою фамилию");
            homeWork3.LastName = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Введи свой город проживания");
            homeWork3.City = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("Задайте координаты вывода текста\n");
            Console.WriteLine("Координата X\n");
            int textCoordinateX = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Координата Y\n");
            int textCoordinateY = Convert.ToInt32(Console.ReadLine());

            homeWork3.Print(textCoordinateX, textCoordinateY);

            #endregion
        }
    }
}
