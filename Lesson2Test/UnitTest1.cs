using Lesson2_HW1;
using Lesson2_HW2;
using Lesson2_HW4;
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
        [TestMethod]
        public void Lesson2_HW3SummOfOddPositiveNumbers()
        {
            Lesson2_HW3.Work work = new();
            work.SummOfOddpositiveNumbers(13);
            work.SummOfOddpositiveNumbers(-7);
            work.SummOfOddpositiveNumbers(0);
            work.SummOfOddpositiveNumbers(4);
            work.SummOfOddpositiveNumbers(17);
            var expectedSumm = 30;
            var actualSumm = work.Summ;
            Assert.AreEqual(expectedSumm, actualSumm);
        }
        [TestMethod]
        public void Lesson2_HW4AuthorizedUser()
        {
            Lesson2_HW4.Work work = new();
            User user = new() { UserLogin = "Xillioner", UserPassword = "12345" };
            work.Authorize(user);
            var expectedIsAuthorized = true;
            var actualIsAuthorized = work.IsAuthorized;
            Assert.AreEqual(expectedIsAuthorized, actualIsAuthorized);
        }
        [TestMethod]
        [Description("Избыточная масса тела (предожирение) - вам следует похудеть на")]
        public void Lesson2_HW4CheckBMI1()
        {
            Lesson2_HW4.Work work = new();
            User user = new() { UserLogin = "Xillioner", UserPassword = "12345" };
            work.Authorize(user);
            if (work.IsAuthorized)
            {
                user.Height = 198;
                user.Weight=100;
                work.AuthorizedArea(user, 1);
            }
            var expectedIndexBodyWeight = 25.507601265177023;
            var expectedIndexHelper = "Избыточная масса тела (предожирение) - вам следует похудеть на";
            var expectedExtraWeight = 1.99;

            var actualIndexBodyWeight = user.IndexBodyWeight;
            var actualIndexHelper = user.IndexHelper;
            var actualExtraWeight = user.ExtraWeight;

            Assert.AreEqual(expectedExtraWeight, actualExtraWeight);
            Assert.AreEqual(expectedIndexHelper, actualIndexHelper);
            Assert.AreEqual(expectedIndexBodyWeight, actualIndexBodyWeight);
        }
        [TestMethod]
        [Description("Недостаточная(дефицит) массы тела - вам следует набрать")]
        public void Lesson2_HW4CheckBMI2()
        {
            Lesson2_HW4.Work work = new();
            User user = new() { UserLogin = "Xillioner", UserPassword = "12345" };
            work.Authorize(user);
            if (work.IsAuthorized)
            {
                user.Height = 198;
                user.Weight = 72;
                work.AuthorizedArea(user, 1);
            }
            var expectedIndexBodyWeight = 18.365472910927458;
            var expectedIndexHelper = "Недостаточная (дефицит) массы тела - вам следует набрать";
            var expectedExtraWeight = 0.5273999999999922;

            var actualIndexBodyWeight = user.IndexBodyWeight;
            var actualIndexHelper = user.IndexHelper;
            var actualExtraWeight = user.ExtraWeight;

            Assert.AreEqual(expectedExtraWeight, actualExtraWeight);
            Assert.AreEqual(expectedIndexHelper, actualIndexHelper);
            Assert.AreEqual(expectedIndexBodyWeight, actualIndexBodyWeight);
        }
        [TestMethod]
        [Description("Выраженный дефицит массы тела - вам следует набрать")]
        public void Lesson2_HW4CheckBMI3()
        {
            Lesson2_HW4.Work work = new();
            User user = new() { UserLogin = "Xillioner", UserPassword = "12345" };
            work.Authorize(user);
            if (work.IsAuthorized)
            {
                user.Height = 198;
                user.Weight = 50;
                work.AuthorizedArea(user, 1);
            }
            var expectedIndexBodyWeight = 12.753800632588511;
            var expectedIndexHelper = "Выраженный дефицит массы тела - вам следует набрать";
            var expectedExtraWeight = 22.5274;

            var actualIndexBodyWeight = user.IndexBodyWeight;
            var actualIndexHelper = user.IndexHelper;
            var actualExtraWeight = user.ExtraWeight;

            Assert.AreEqual(expectedExtraWeight, actualExtraWeight);
            Assert.AreEqual(expectedIndexHelper, actualIndexHelper);
            Assert.AreEqual(expectedIndexBodyWeight, actualIndexBodyWeight);
        }
        [TestMethod]
        [Description("Норма")]
        public void Lesson2_HW4CheckBMI4()
        {
            Lesson2_HW4.Work work = new();
            User user = new() { UserLogin = "Xillioner", UserPassword = "12345" };
            work.Authorize(user);
            if (work.IsAuthorized)
            {
                user.Height = 198;
                user.Weight = 98;
                work.AuthorizedArea(user, 1);
            }
            var expectedIndexBodyWeight = 24.997449239873482;
            var expectedIndexHelper = "Норма";
            var expectedExtraWeight = 0;

            var actualIndexBodyWeight = user.IndexBodyWeight;
            var actualIndexHelper = user.IndexHelper;
            var actualExtraWeight = user.ExtraWeight;

            Assert.AreEqual(expectedExtraWeight, actualExtraWeight);
            Assert.AreEqual(expectedIndexHelper, actualIndexHelper);
            Assert.AreEqual(expectedIndexBodyWeight, actualIndexBodyWeight);
        }
        [TestMethod]
        [Description("Ожирение 1 степени - вам следует похудеть на")]
        public void Lesson2_HW4CheckBMI5()
        {
            Lesson2_HW4.Work work = new();
            User user = new() { UserLogin = "Xillioner", UserPassword = "12345" };
            work.Authorize(user);
            if (work.IsAuthorized)
            {
                user.Height = 198;
                user.Weight = 130;
                work.AuthorizedArea(user, 1);
            }
            var expectedIndexBodyWeight = 33.15988164473013;
            var expectedIndexHelper = "Ожирение 1 степени - вам следует похудеть на";
            var expectedExtraWeight = 31.98999999999999;

            var actualIndexBodyWeight = user.IndexBodyWeight;
            var actualIndexHelper = user.IndexHelper;
            var actualExtraWeight = user.ExtraWeight;

            Assert.AreEqual(expectedExtraWeight, actualExtraWeight);
            Assert.AreEqual(expectedIndexHelper, actualIndexHelper);
            Assert.AreEqual(expectedIndexBodyWeight, actualIndexBodyWeight);
        }
        [TestMethod]
        [Description("Ожирение 2 степени - вам следует похудеть на")]
        public void Lesson2_HW4CheckBMI6()
        {
            Lesson2_HW4.Work work = new();
            User user = new() { UserLogin = "Xillioner", UserPassword = "12345" };
            work.Authorize(user);
            if (work.IsAuthorized)
            {
                user.Height = 198;
                user.Weight = 140;
                work.AuthorizedArea(user, 1);
            }
            var expectedIndexBodyWeight = 35.710641771247836;
            var expectedIndexHelper = "Ожирение 2 степени - вам следует похудеть на";
            var expectedExtraWeight = 41.990000000000016;

            var actualIndexBodyWeight = user.IndexBodyWeight;
            var actualIndexHelper = user.IndexHelper;
            var actualExtraWeight = user.ExtraWeight;

            Assert.AreEqual(expectedExtraWeight, actualExtraWeight);
            Assert.AreEqual(expectedIndexHelper, actualIndexHelper);
            Assert.AreEqual(expectedIndexBodyWeight, actualIndexBodyWeight);
        }
        [TestMethod]
        [Description("Ожирение 3 степени - вам следует похудеть на")]
        public void Lesson2_HW4CheckBMI7()
        {
            Lesson2_HW4.Work work = new();
            User user = new() { UserLogin = "Xillioner", UserPassword = "12345" };
            work.Authorize(user);
            if (work.IsAuthorized)
            {
                user.Height = 198;
                user.Weight = 160;
                work.AuthorizedArea(user, 1);
            }
            var expectedIndexBodyWeight = 40.81216202428324;
            var expectedIndexHelper = "Ожирение 3 степени - вам следует похудеть на";
            var expectedExtraWeight = 61.99000000000001;

            var actualIndexBodyWeight = user.IndexBodyWeight;
            var actualIndexHelper = user.IndexHelper;
            var actualExtraWeight = user.ExtraWeight;

            Assert.AreEqual(expectedExtraWeight, actualExtraWeight);
            Assert.AreEqual(expectedIndexHelper, actualIndexHelper);
            Assert.AreEqual(expectedIndexBodyWeight, actualIndexBodyWeight);
        }
    }
}
