﻿using System;
using LetterFinderLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void SkipVowelsTest()
        {
            LetterManager myLetterManager = new LetterManager();

            //Imi?: Ez így "szabályos" vagy illik írni minden meghívásra külön TestMethodot?"
            Assert.AreEqual('b', myLetterManager.SkipIfVowel('a'));
            Assert.AreEqual('b', myLetterManager.SkipIfVowel('b'));
           // Assert.AreEqual('b', myLetterManager.SkipIfVowel('c'));
           // Assert.AreEqual('f', myLetterManager.SkipIfVowel('e'));





        }
    }
}
