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
            Console.OutputEncoding = Encoding.UTF8;
            Console.SetCursorPosition(30, 1);
            Console.WriteLine("Анкета");
            Console.WriteLine();

            Console.WriteLine("Введи своё имя");
            string firstName = Console.ReadLine();

            Console.WriteLine("Введи свою фамилию");
            string lastName = Console.ReadLine();

            Console.WriteLine("Введи свой возраст");
            string age = Console.ReadLine();

            Console.WriteLine("Введи свой рост");
            string height = Console.ReadLine();

            Console.WriteLine("Введи свой вес");
            string weight = Console.ReadLine();

            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine(firstName + " " + lastName + ", " + age);
            Console.WriteLine("Рост: {0}, Вес: {1}", height, weight);
        }
    }
}
