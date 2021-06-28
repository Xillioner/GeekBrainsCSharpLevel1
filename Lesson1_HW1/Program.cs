using System;
using System.Text;

namespace Lesson1_HW1
{
    class Program
    {
        /// <summary>
        /// 1. Написать программу “Анкета”. Последовательно задаются вопросы (имя, фамилия, возраст, рост, вес). В результате вся информация выводится в одну строчку.
        /// а) используя склеивание;
        /// б) используя форматированный вывод.
        /// </summary>
        /// Коньшин Евгений Анатольевич
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            HomeWork1 lesson1_HW1 = new(); 
            Console.OutputEncoding = Encoding.UTF8;
            Console.SetCursorPosition(30, 1);
            Console.WriteLine("Анкета");
            Console.WriteLine();

            Console.WriteLine("Введи своё имя");
            lesson1_HW1.FirstName = Console.ReadLine();

            Console.WriteLine("Введи свою фамилию");
            lesson1_HW1.LastName = Console.ReadLine();

            Console.WriteLine("Введи свой возраст");
            lesson1_HW1.Age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введи свой рост");
            lesson1_HW1.Height = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введи свой вес");
            lesson1_HW1.Weight = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(lesson1_HW1.OutputString1);
            Console.WriteLine(lesson1_HW1.OutPutString2);

        }
    }
}
