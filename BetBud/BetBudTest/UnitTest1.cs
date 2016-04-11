using NUnit.Framework;

namespace BetBudTest
{
    [TestFixture]
    public class UnitTest1
    {
        [Test]
        public void TestMethod1()
        {
            //Arrange
            var i = 5;

            //Act
            var iRes = i + 2;

            //Assert
            Assert.AreEqual(iRes, 7);

        }
    }
}
