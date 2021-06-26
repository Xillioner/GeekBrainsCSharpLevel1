using System;

namespace Lesson2_HW2
{
    internal class Work
    {
        public int NumberLength { get; private set; }

        public void ElementCounter(int number)
        {
            NumberLength= number.ToString().Length;
        }
    }
}