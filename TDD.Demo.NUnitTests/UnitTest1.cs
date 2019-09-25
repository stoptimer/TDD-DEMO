using NUnit.Framework;

namespace TDD.Demo.NUnitTests
{
    public class Tests
    {
        private string _messageToCheck;
        [SetUp]
        public void Setup()
        {
            _messageToCheck = "this test message";
        }

        [Test]
        public void MsssageLengthGreaterThanZero()
        {

            if (_messageToCheck.Length > 0)
            {
                Assert.Pass();
            }
            else
            {
                Assert.Fail();
            }
        }
        [Test]
        public void MessageLengthGreaterThan100()
        {
            if (_messageToCheck.Length > 100)
            {
                Assert.Pass();
            }
            else
            {
                Assert.Fail();
            }
        }
    }
}