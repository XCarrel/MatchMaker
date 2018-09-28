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
        public void TestPersonDiscord()
        {
            Person p1 = new Person("Person1", 1);
            Person p2 = new Person("Person2", 1);
            p1.SetResponses(new List<int> { 3, 4, 1, 2, 1, 5 });
            p2.SetResponses(new List<int> { 1, 4, 1, 3, 3, 3 });
            // Discord is 82: (1-3)^2+(4-4)^2+(1-1)^2+(3-2)^2+(3-1)^2+(3-5)^2
            Assert.AreEqual(p1.GetDiscordWith(p2), 13, "Bad computation of Discord score");
        }
    }
}
