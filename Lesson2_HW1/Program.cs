using System;

namespace Lesson2_HW1
{
    /// <summary>
    /// Написать метод возвращающий минимальное из трех чисел;
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Work work = new();
            work.MinimalOfThreeNumbers(1, 2, 3);
        }
    }
}
