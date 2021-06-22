using Lesson1_HW1;
using Lesson1_HW2;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Lesson1Test
{
    [TestClass]
    public class Lesson1Test
    {
        [TestMethod]
        public void Lesson1_HW1ProgramTest()
        {
            HomeWork1 lesson1_HW1 = new()
            {
                FirstName = "Evgeny",
                LastName = "Konshin",
                Age = 34,
                Height = 198,
                Weight = 100,
            };

            var expectedString1 = "Evgeny Konshin, 34";
            var expectedString2 = "Рост: 198, Вес: 100";

            var actualValue1 = lesson1_HW1.OutputString1;
            var actualValue2 = lesson1_HW1.OutPutString2;

            Assert.AreEqual(expectedString1, actualValue1);
            Assert.AreEqual(expectedString2, actualValue2);
        }

        [TestMethod]
        public void Lesson1_HW2ProgramTest()
        {
            HomeWork2 homeWork2 = new()
            {
                FirstName = "Evgeny",
                Height = 198,
                Weight = 100
            };

            double expectedIndexMass = 0.002550760126517702;
            string expectedFirstName = "Индекс массы тела, Evgeny =";

            double actualIndexMass = homeWork2.IndexMass;
            string actualFirstName = homeWork2.FirstName;

            Assert.AreEqual(expectedIndexMass, actualIndexMass);
            Assert.AreEqual(expectedFirstName, actualFirstName);
        }
        [TestMethod]
        public void Lesson1_HW2Length()
        {
            HomeWork2 homeWork2 = new();
            homeWork2.LengthFromAToB(new string[]{ "0","1","1","1"});
            

            double expectedLength = 1;

            double actualLength = homeWork2.Length;

            Assert.AreEqual(expectedLength, actualLength);
        }
    }
}
