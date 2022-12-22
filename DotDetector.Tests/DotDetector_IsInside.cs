using NUnit.Framework;

namespace DotDetector.Tests
{
    public class DotDetector_IsInside
    {
        private Circle? circle;

        [SetUp]
        public void Setup()
        {
            circle = new(0, -1, 2);
        }

        [Test]
        [TestCase(0, 0)]
        [TestCase(2, -1)]
        public void DotDetector_IsPointInside_ReturnTrue(int x, int y)
        {
            var actual = circle?.IsPointBelong(x, y);
            Assert.AreEqual(true, actual);
        }

        [Test]
        public void DotDetector_IsPointInside_ReturnFalse()
        {
            var actual = circle?.IsPointBelong(-1, -3);
            Assert.AreEqual(false, actual);
        }
    }
}