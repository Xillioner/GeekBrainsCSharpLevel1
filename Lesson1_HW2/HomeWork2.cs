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
        private string firstName;
    }
}
