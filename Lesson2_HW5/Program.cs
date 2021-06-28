using System;
using System.Text;

namespace Lesson2_HW5
{
    /// <summary>
    /// *Написать программу подсчета количества “Хороших” чисел в диапазоне от 1 до 1 000 000. 
    /// Хорошим называется число, которое делится на сумму своих цифр. 
    /// Реализовать подсчет времени выполнения программы, используя структуру DateTime. 
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            var numberCount =0;
            var goodNumberCount = 0;
            int timeResult=0;
            DateTime programRunTime = DateTime.Now;
            for (int number = 0; number < 1000000; number++)
            {
                numberCount = number.ToString().Length;
                if (number % numberCount == 0)
                {
                    goodNumberCount++;
                }
            }
            timeResult = (DateTime.Now - programRunTime).Milliseconds;
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine($"{goodNumberCount} - хороших чисел\nВремя выполнения программы - {timeResult}");
        }
    }
}
