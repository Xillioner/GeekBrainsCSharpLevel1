using System;

namespace Lesson1_HW3
{
    public class HomeWork3
    {
        public int? Variable1 { get; set; }
        public int? Variable2 { get; set; }
        public int? Variable3 { get; private set; }
        public string ObjVariable1 { get; set; }
        public string ObjVariable2 { get; set; }

        public void ChangeThreeVariables()
        {
            if (Variable1 == null || Variable2 == null)
            {
                Console.WriteLine("Переменные не инициализированы");
                return;
            }
            Variable3 = Variable1;
            Variable1 = Variable2;
            Variable2 = Variable3;
            Variable3 = null;
        }

        public void ChangeTwoVariables()
        {
            if (ObjVariable1 == null || ObjVariable2 == null)
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
