using System;
using System.Text;

namespace Lesson2_HW3
{
    /// <summary>
    /// С клавиатуры вводятся числа, пока не будет введен 0. Подсчитать сумму всех нечетных положительных чисел;
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Work work = new();
            Console.OutputEncoding = Encoding.UTF8;
            Console.SetCursorPosition(30, 1);
            Console.WriteLine($"Подсчёт суммы всех нечетных положительных чисел\nВыход = 0\nНачинай вводить числа.");
            int number=0;
            do
            {
                number = Convert.ToInt32(Console.ReadLine());
                work.SummOfOddpositiveNumbers(number);

            }
            while (number != 0);

            Console.WriteLine($"Сумма всех нечётных положительных чисел = {work.Summ}");
        }
    }
}
