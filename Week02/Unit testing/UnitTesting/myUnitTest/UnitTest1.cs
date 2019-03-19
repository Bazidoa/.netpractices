using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitTesting;

namespace myUnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestHello()
        {
            //Arrange
            Gentleman gentlemanToTest = new Gentleman();

            string excpectedResult = "Hello Billy Mack";

            //Act
            string actualResult = gentlemanToTest.SayHello("Billy Mack");



            //Assert
            Assert.AreEqual(excpectedResult, actualResult);

        }
    }
}
