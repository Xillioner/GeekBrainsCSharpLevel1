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
                variable1 = 17,
                variable2 = 4
            };
            Console.OutputEncoding = Encoding.UTF8;
            Console.SetCursorPosition(40, 1);
            Console.WriteLine("Программа обмена значениями двух переменных\n");
            #region а) с использованием третьей переменной;
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("C использованием третьей переменной\n");

            Console.WriteLine($"Начальные значения: \"{homeWork3.variable1}\", \"{homeWork3.variable2}\", \"{homeWork3.variable3}\"");

            homeWork3.variable3 = homeWork3.variable1;
            homeWork3.variable1 = homeWork3.variable2;
            homeWork3.variable2 = homeWork3.variable3;
            homeWork3.variable3 = "";

            Console.WriteLine($"Конечные значения: \"{homeWork3.variable1}\", \"{homeWork3.variable2}\", \"{homeWork3.variable3}\"\n\n");
            #endregion

            #region б) * без использования третьей переменной.
            Console.WriteLine("Без использования третьей переменной\n");
            Console.WriteLine($"Начальные значения: \"{homeWork3.ObjVariable1}\", \"{homeWork3.ObjVariable2}\"");

            Console.WriteLine($"Конечные значения: \"{homeWork3.ObjVariable1}\", \"{homeWork3.ObjVariable2}\"");
            #endregion

        }
    }
}
