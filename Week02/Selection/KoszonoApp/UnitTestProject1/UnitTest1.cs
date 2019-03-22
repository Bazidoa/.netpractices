using System;
using KoszonoApp;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void KoszonoMethodReggel()
        {

            Koszono selectionEx = new Koszono();

            Assert.AreEqual("Jó reggelt!", selectionEx.SaySomeKindOfGreeting(9, 01));
           

        }

        [TestMethod]
        public void KoszonoMethodNap()
        {

            Koszono selectionEx = new Koszono();

            Assert.AreEqual("Jó napot!", selectionEx.SaySomeKindOfGreeting(18, 29));

        }
        [TestMethod]
        public void KoszonoMethodEste()
        {

            Koszono selectionEx = new Koszono();

          
            Assert.AreEqual("Jó estét", selectionEx.SaySomeKindOfGreeting(18, 31));
            //Assert.AreEqual("Jó estét", selectionEx.SaySomeKindOfGreeting(19, 59));

        }
        [TestMethod]
        public void KoszonoMethodEjjel()
        {

            Koszono selectionEx = new Koszono();

            Assert.AreEqual("Jó éjt", selectionEx.SaySomeKindOfGreeting(23, 34));
            //Assert.AreEqual("Jó éjt", selectionEx.SaySomeKindOfGreeting(1, 23));
           
        }
    }
    
}
