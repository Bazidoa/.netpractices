using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SocialNeworkClassLibrary;

namespace SocialNetworkExercise.Tests
{

    [TestClass]
    public class SocialNetworkTest
    {
        private SocialNetwork socialNetwork;

        [TestInitialize]
        public void Initialize()
        {
            socialNetwork = new SocialNetwork();

            socialNetwork.AddMember("Joe");
            socialNetwork.AddMember("John");
            socialNetwork.AddMember("Jane");
            socialNetwork.AddMember("Richard");
        }

      /*  [TestMethod]
        public void AddMember()
        {
            Assert.AreEqual(4, socialNetwork.Members.Count);
            Assert.AreEqual("John", socialNetwork.Members.ElementAt(1).Name);
        }*/

        [TestMethod]
        public void FindByMember()
        {
           // Assert.AreEqual("", socialNetwork.FindByName("Jack").Name);
            Assert.AreEqual("Jane", socialNetwork.FindByName("Jane").Name);
        }

        [TestMethod]
        public void TestGetBidirectionalConnections()
        {
            socialNetwork.Connect("Joe", "John");
            socialNetwork.Connect("John", "Joe");

            Assert.AreEqual("Joe - John, John - Joe", socialNetwork.GetBidirectionalConnections());
        }

        [TestMethod]
        public void TestToString()
        {
            socialNetwork.Connect("Joe", "John");
            socialNetwork.Connect("John", "Joe");

            Assert.AreEqual("Joe: John\nJohn: Joe\nJane: -\nRichard: -\n", socialNetwork.ToString());
        }
    }
}
