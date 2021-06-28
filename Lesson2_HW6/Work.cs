using System;

namespace Lesson2_HW6
{
    public class Work
    {
        
        public bool Reverse { get; set; }
        public int Summ { get; set; }

        public void RecursionAtoB(int a, int b)
        {
            Console.WriteLine(a);
            if (a != b && a < b)
            {
                a++;
                RecursionAtoB(a, b);
            }
            else if (a != b && a > b)
            {
                a--;
                RecursionAtoB(a, b);
            }
        }
        public void RecursionSummAtoB(int a, int b)
        {

            if (!Reverse&&a <= b)
            {
                Summ += a;
                a++;
                RecursionSummAtoB(a, b);
            }
            else if (Reverse&&a >= b)
            {
                Summ += a;
                a--;
                RecursionSummAtoB(a, b);
            }
        }
    }
}