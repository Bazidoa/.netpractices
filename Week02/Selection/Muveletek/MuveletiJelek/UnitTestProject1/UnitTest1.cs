using System;
using AlapMuveletekLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CalculateTestAdd()
        {
            MathCalculator testCalc = new MathCalculator();
            
            double expectedResult = 7;

            double actualResult = testCalc.Calculate(5, 2, "+");

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void CalculateTestSubs()
        {
            MathCalculator testCalc = new MathCalculator();

            double expectedResult = 3;

            double actualResult = testCalc.Calculate(5, 2, "-");

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void CalculateTestTimes()
        {
            MathCalculator testCalc = new MathCalculator();

            double expectedResult = 10;

            double actualResult = testCalc.Calculate(5, 2, "*");

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void CalculateTestDevide()
        {
            MathCalculator testCalc = new MathCalculator();

            double expectedResult = 2.5;

            double actualResult = testCalc.Calculate(5, 2, "/");

            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
