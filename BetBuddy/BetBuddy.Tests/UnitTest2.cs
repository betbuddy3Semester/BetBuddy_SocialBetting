using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BetBuddy.Tests
{
    [TestClass]
    public class UnitTest2
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Arrange
            int i = 5;
            int e = 5;

            //Act
            var x = i + e;

            //Assure
            Assert.AreEqual(10, x);
        }
    }
}
