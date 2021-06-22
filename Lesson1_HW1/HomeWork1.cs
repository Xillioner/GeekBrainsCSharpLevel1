using System;
using System.Text;

namespace Lesson1_HW1
{
    public class HomeWork1
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public int Height { get; set; }
        public int Weight { get; set; }
        public string OutputString1
        {
            get
            {
                return FirstName + " " + LastName + ", " + Age;
            }
        }
        public string OutPutString2
        {
            get
            {
                return String.Format("Рост: {0}, Вес: {1}", Height, Weight);
            }
        }
    }
}
