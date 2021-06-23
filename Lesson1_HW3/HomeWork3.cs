using System;

namespace Lesson1_HW3
{
    public class HomeWork3
    {
        public int variable1 { get; set; }
        public int variable2 { get; set; }
        public int variable3 { get; set; }
        public string ObjVariable1 {get; set;}
        public string ObjVariable2 { get; set; }

        public HomeWork3()
        {
            ChangeTwoVariables();
        }

        private void ChangeTwoVariables()
        {
            if (ObjVariable1==null||ObjVariable2==null)
            {
                Console.WriteLine("Переменные не инициализированы");
                return;
            }
            this.ObjVariable1 = ObjVariable1 + ObjVariable2;
            this.ObjVariable2 = ObjVariable1.Remove(ObjVariable1.IndexOf(ObjVariable2), ObjVariable2.Length);
            this.ObjVariable1 = ObjVariable1.Remove(ObjVariable1.IndexOf(ObjVariable2), ObjVariable2.Length);
        }
    }
}
