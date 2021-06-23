using Lesson2_HW1;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Lesson2Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Lesson2_HW1MinimalNumber1()
        {
            Work work = new();
            work.MinimalOfThreeNumbers(1, 2, 3);

            var actualNumber = 1;

            var expectedNumber = work.MinimalNumber;

            Assert.AreEqual(expectedNumber, actualNumber);
        }
        [TestMethod]
        public void Lesson2_HW1MinimalNumber2()
        {
            Work work = new();
            work.MinimalOfThreeNumbers(2, 1, 3);

            var actualNumber = 1;

            var expectedNumber = work.MinimalNumber;

            Assert.AreEqual(expectedNumber, actualNumber);
        }
        [TestMethod]
        public void Lesson2_HW1MinimalNumber3()
        {
            Work work = new();
            work.MinimalOfThreeNumbers(3, 2, 1);

            var actualNumber = 1;

            var expectedNumber = work.MinimalNumber;

            Assert.AreEqual(expectedNumber, actualNumber);
        }
    }
}
