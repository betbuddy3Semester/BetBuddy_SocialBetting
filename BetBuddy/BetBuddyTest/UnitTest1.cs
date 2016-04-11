using NUnit.Framework;

namespace BetBuddyTest
{
    [TestFixture]
    public class UnitTest1
    {
        [Test]
        public void TestMethod1()
        {
            var i = 5;
            var e = 10;
            var x = 15;
            var y = 20;
            Assert.AreEqual(i, 5);
            Assert.AreEqual(e, 10);
            Assert.AreEqual(x, 15);
            Assert.AreEqual(y, 20);
        }
    }
}