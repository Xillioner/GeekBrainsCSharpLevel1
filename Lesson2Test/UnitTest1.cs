using Lesson2_HW1;
using Lesson2_HW2;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Lesson2Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Lesson2_HW1MinimalNumber1()
        {
            Lesson2_HW1.Work work = new();
            work.MinimalOfThreeNumbers(1, 2, 3);

            var actualNumber = 1;

            var expectedNumber = work.MinimalNumber;

            Assert.AreEqual(expectedNumber, actualNumber);
        }
        [TestMethod]
        public void Lesson2_HW1MinimalNumber2()
        {
            Lesson2_HW1.Work work = new();
            work.MinimalOfThreeNumbers(2, 1, 3);

            var actualNumber = 1;

            var expectedNumber = work.MinimalNumber;

            Assert.AreEqual(expectedNumber, actualNumber);
        }
        [TestMethod]
        public void Lesson2_HW1MinimalNumber3()
        {
            Lesson2_HW1.Work work = new();
            work.MinimalOfThreeNumbers(3, 2, 1);

            var actualNumber = 1;

            var expectedNumber = work.MinimalNumber;

            Assert.AreEqual(expectedNumber, actualNumber);
        }
        [TestMethod]
        public void Lesson2_HW2NumElements()
        {
            Lesson2_HW2.Work work = new();
            work.ElementCounter(10203949);
            var expectedElementCounter = 8;
            var actualElementCounter = work.NumberLength;
            Assert.AreEqual(expectedElementCounter, actualElementCounter);

        }
    }
}
