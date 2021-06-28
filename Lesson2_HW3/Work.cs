using System;

namespace Lesson2_HW3
{
    public class Work
    {
        public int Summ { get; private set; }

        public void SummOfOddpositiveNumbers(int number)
        {
            if (number > 0 && number % 2 != 0)
            {
                this.Summ =number+ Summ;
            }

        }
    }
}
