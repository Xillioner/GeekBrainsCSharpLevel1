using System;
using System.Text;

namespace Lesson2_HW6
{
    /// <summary>
    /// 6.a) Разработать рекурсивный метод, который выводит на экран числа от a до b;
    ///   б) * Разработать рекурсивный метод, который считает сумму чисел от a до b.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Work work = new();
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Введи число A");
            var a=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введи число B");
            var b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            work.RecursionAtoB(a, b);
            Console.WriteLine();
            if (a>b)
            {
                work.Reverse = true;
            }
            else
            {
                work.Reverse = false;
            }
            work.RecursionSummAtoB(a, b);
            Console.WriteLine(work.Summ);
        }
    }
}
