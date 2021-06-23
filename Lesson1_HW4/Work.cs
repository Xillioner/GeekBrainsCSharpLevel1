using System;

namespace Lesson1_HW4
{
    public class Work
    {
        public void Print(string message, int coursorPositionX, int coursorPositionY)
        {
            Console.SetCursorPosition(coursorPositionX, coursorPositionY);
            Console.WriteLine(message);
        }
        public void Pause()
        {
            Console.WriteLine("\n\nПауза.\nДля продолжения нажми любую кнопку.");
            Console.ReadKey();
        }
    }
}