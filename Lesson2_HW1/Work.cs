namespace Lesson2_HW1
{
    public class Work
    {
        public int MinimalNumber { get;private set; }
        public void MinimalOfThreeNumbers(int variable1, int variable2, int variable3)
        {
            if (variable1 < variable2 && variable1 < variable3)
            {
                MinimalNumber= variable1;
            }
            else if (variable2 < variable3)
            {

                MinimalNumber= variable2;

            }else if (variable3 < variable1)
            {
                MinimalNumber= variable3;
            }
        }
    }
}