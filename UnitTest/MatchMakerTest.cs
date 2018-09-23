using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MatchMaker;
using System.Collections.Generic;

namespace UnitTest
{
    [TestClass]
    public class MatchMakerTest
    {
        [TestMethod]
        public void TestPersonIncompatibility()
        {
            Person p1 = new Person(1,"Person1");
            Person p2 = new Person(2,"Person2");
            p1.setResponses(new List<int> { 3, 4, 7, 8, 1, 9 });
            p2.setResponses(new List<int> { 7, 4, 6, 3, 3, 3 });
            // Incompatibility is 82: (7-3)^2+(4-4)^2+(6-7)^2+(3-8)^2+(3-1)^2+(3-9)^2
            Assert.AreEqual(p1.getIncompatibilityWith(p2), 82, "Bad computation of incompatibility score");
        }
    }
}
