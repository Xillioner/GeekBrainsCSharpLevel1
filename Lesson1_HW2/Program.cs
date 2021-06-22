using System;
using System.Text;

namespace Lesson1_HW2
{
    /// <summary>
    /// 2. Ввести вес и рост человека. Расчитать и вывести индекс массы тела(ИМТ) по формуле I=m/(h*h); где m-масса тела в килограммах, h - рост в метрах
    /// Интерпритировать показания ИМТ.
    /// а) Написать программу, которая подсчитывает расстояние между точками с координатами x1, y1 и x2,y2 по формуле r = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2).Вывести результат используя спецификатор формата .2f(с двумя знаками после запятой);
    /// б) * Выполните предыдущее задание оформив вычисления расстояния между точками в виде метода;
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.SetCursorPosition(40, 1);
            HomeWork2 homeWork2 = new();
            Console.WriteLine("Индекс массы тела");

            Console.WriteLine("Введи своё имя");
            homeWork2.FirstName = Console.ReadLine();

            Console.WriteLine("Введи свой вес");
            homeWork2.Weight = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введи свой рост");
            homeWork2.Height = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"Индекс массы тела, {homeWork2.FirstName} = {homeWork2.IndexMass}");
        }
    }
}
