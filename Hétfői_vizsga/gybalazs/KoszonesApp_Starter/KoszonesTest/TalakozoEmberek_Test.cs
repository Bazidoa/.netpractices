using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Utilities;
using KoszonesClassLibrary;

namespace KoszonesTest
{
    [TestClass]
    public class TalakozoEmberek_Test
    {
        [TestMethod]
        public void Talalkozik_Ferfi_Gyerek()
        {
            //Arrange
            string expectedKoszontes;
            string actualKoszontes;
            Ember lEmber;
            Ember rEmber;
            DateTime datum;

            lEmber = new Ember("Imi", new DateTime(1970, 9, 12), Gender.HimNemu);
            rEmber = new Ember("Jonci", new DateTime(2010, 3, 21), Gender.NoNemu);
            datum = new DateTime(2019, 03, 22);
            expectedKoszontes = "Szervusz Jonci!" + " <--> " + "Jó napot Imi bácsi!";
            //Act
            actualKoszontes = TalalkozoEmberek.KoszonnekEgymasnak(lEmber, rEmber, datum);
            //Assert
            Assert.AreEqual(expectedKoszontes, actualKoszontes);
        }

        [TestMethod]
        public void Talalkozik_Ferfi_No()
        {
            //Arrange
            string expectedKoszontes;
            string actualKoszontes;
            Ember lEmber;
            Ember rEmber;
            DateTime datum;

            lEmber = new Ember("Imi", new DateTime(1970, 9, 12), Gender.HimNemu);
            rEmber = new Ember("Zsuzsa", new DateTime(1975, 3, 21), Gender.NoNemu);
            datum = new DateTime(2019, 03, 22);
            expectedKoszontes = "Szia Zsuzsa!" + " <--> " + "Szia Imi!";
            //Act
            actualKoszontes = TalalkozoEmberek.KoszonnekEgymasnak(lEmber, rEmber, datum);
            //Assert
            Assert.AreEqual(expectedKoszontes, actualKoszontes);
        }

        [TestMethod]
        public void Talalkozik_Gyerek_No()
        {
            //Arrange
            string expectedKoszontes;
            string actualKoszontes;
            Ember lEmber;
            Ember rEmber;
            DateTime datum;

            lEmber = new Ember("Pityu", new DateTime(2017, 9, 12), Gender.HimNemu);
            rEmber = new Ember("Zsuzsa", new DateTime(1975, 3, 21), Gender.NoNemu);
            datum = new DateTime(2019, 03, 22);
            expectedKoszontes = "Csókolom Zsuzsa néni!" + " <--> " + "Szervusz Pityu!";
            //Act
            actualKoszontes = TalalkozoEmberek.KoszonnekEgymasnak(lEmber, rEmber, datum);
            //Assert
            Assert.AreEqual(expectedKoszontes, actualKoszontes);
        }

        [TestMethod]
        public void Talalkozik_Gyerek_Gyerek()
        {
            //Arrange
            string expectedKoszontes;
            string actualKoszontes;
            Ember lEmber;
            Ember rEmber;
            DateTime datum;

            lEmber = new Ember("Pityu", new DateTime(2017, 9, 12), Gender.HimNemu);
            rEmber = new Ember("Peti", new DateTime(2010, 3, 21), Gender.HimNemu);
            datum = new DateTime(2019, 03, 22);
            expectedKoszontes = "Szia Peti!" + " <--> " + "Szia Pityu!";
            //Act
            actualKoszontes = TalalkozoEmberek.KoszonnekEgymasnak(lEmber, rEmber, datum);
            //Assert
            Assert.AreEqual(expectedKoszontes, actualKoszontes);
        }

        [TestMethod]
        public void Talalkozik_Gyerek_Ferfi()
        {
            //Arrange
            string expectedKoszontes;
            string actualKoszontes;
            Ember lEmber;
            Ember rEmber;
            DateTime datum;

            lEmber = new Ember("Pityu", new DateTime(2017, 9, 12), Gender.HimNemu);
            rEmber = new Ember("Imi", new DateTime(1970, 3, 21), Gender.HimNemu);
            datum = new DateTime(2019, 03, 22);
            expectedKoszontes = "Jó napot Imi bácsi!" + " <--> " + "Szervusz Pityu!";
            //Act
            actualKoszontes = TalalkozoEmberek.KoszonnekEgymasnak(lEmber, rEmber, datum);
            //Assert
            Assert.AreEqual(expectedKoszontes, actualKoszontes);
        }

        [TestMethod]
        public void Talalkozik_No_Gyerek()
        {
            //Arrange
            string expectedKoszontes;
            string actualKoszontes;
            Ember lEmber;
            Ember rEmber;
            DateTime datum;

            lEmber = new Ember("Zsuzsa", new DateTime(1969, 9, 12), Gender.NoNemu);
            rEmber = new Ember("Pisti", new DateTime(2010, 3, 21), Gender.HimNemu);
            datum = new DateTime(2019, 03, 22);
            expectedKoszontes = "Szervusz Pisti!" + " <--> " + "Csókolom Zsuzsa néni!"  ;
            //Act
            actualKoszontes = TalalkozoEmberek.KoszonnekEgymasnak(lEmber, rEmber, datum);
            //Assert
            Assert.AreEqual(expectedKoszontes, actualKoszontes);
        }
    }
}
