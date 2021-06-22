using System;

namespace Lesson1_HW2
{
    public class HomeWork2
    {
        public string FirstName
        {
            get
            {
                return $"Индекс массы тела, {firstName} =";
            }
            set { firstName = value; }
        }
        public double Weight { get; set; }
        public double Height { get; set; }
        public double IndexMass
        {
            get
            {
                return Weight / (Math.Pow(Height, 2));
            }
        }
        public double Length { get; private set; }
        private string firstName;

        public void LengthFromAToB(string[] coordinates)
        {
            double.TryParse(coordinates[0], out double coordinateX1);
            double.TryParse(coordinates[1], out double coordinateY1);
            double.TryParse(coordinates[2], out double coordinateX2);
            double.TryParse(coordinates[3], out double coordinateY2);

            Length = Math.Sqrt(Math.Pow(coordinateX2 - coordinateX1, 2) + Math.Pow(coordinateY2 - coordinateY1, 2));
        }

        public int ShowMenu()
        {
            Console.WriteLine("Меню:\n1 - Вычислить индекс массы тела.\n2 - Вычислить расстояние от точки до точки.");
            return Convert.ToInt32(Console.ReadLine());
        }
    }
}
