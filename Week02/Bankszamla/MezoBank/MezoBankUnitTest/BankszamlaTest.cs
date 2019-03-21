using System;
using MezoBankLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MezoBankUnitTest
{
    [TestClass] //attribútum 
    public class BankszamlaTest
    {
        [TestMethod]
        public void EgyenlegNoveles()
        {
            //Arrange
            int expectedEgyenleg = 120;
            Bankszamla szla = new Bankszamla("tesztBankszamla");
            //Act

            int actualEgyenleg = szla.EgyenlegNovel(120);
            //Assert
            Assert.AreEqual(expectedEgyenleg, actualEgyenleg);
        }
        [TestMethod]
        public void EgyenlegCsokkentes()
        {
            //Arrange
            Bankszamla szla2 = new Bankszamla("teszt2Bankszamla");
            int expectedResult = -100;

            //Act
            int actualResult = szla2.EgyenlegCsokkent(100);

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void NemLehetNullaTeszt()
        {
            //Arrange
            Bankszamla szla3 = new Bankszamla("teszbankszamla3");

            //Act
            szla3.NemLehetNegativValidalo(-10);

            //Assert - expected result -> exception, assert not needed.
        }

        [TestMethod]
        public void SzamlaszamSetValidator()
        {
            //Arrange
            Bankszamla szla4 = new Bankszamla("teszt4Bankszamla");

            int excpectedSzlaszam = 12345;

            //Act
            int actualSzlaszam = (szla4.Szamlaszam = 12345);

            //Assert
            Assert.AreEqual(excpectedSzlaszam, actualSzlaszam);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void SzamlaszamSetValidatorNotGood()
        {
            //Arrange
            Bankszamla szla5 = new Bankszamla("teszt5bankszamla");

            //Act
            szla5.Szamlaszam = 123;


        }

    }
}
