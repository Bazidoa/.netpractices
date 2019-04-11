using System;
using ExtensionMethodsProba;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ExtensionTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CharCountTest()
        {
            ExtensionMetodProbaforString firstExt = new ExtensionMetodProbaforString("Ez egy szöveg", 'e');

            Assert.AreEqual(2, firstExt.myText.CharCounter(firstExt.myChar));

        }
    }
}
