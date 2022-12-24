using NUnit.Framework;

namespace LeapYearApp.Tests
{
    public class LeapYear_IsLeap
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        [TestCase(2000)]
        [TestCase(2004)]
        [TestCase(2184)]
        public void IsYearLeap_ReturnTrue(int year)
        {
            var actual = LeapYearService.IsLeap(year);
            Assert.AreEqual(true, actual);
        }

        [Test]
        [TestCase(1900)]
        [TestCase(2001)]
        [TestCase(1998)]
        public void IsYearLeap_ReturnFalse(int year)
        {
            var actual = LeapYearService.IsLeap(year);
            Assert.AreEqual(false, actual);
        }
    }
}