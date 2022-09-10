using NUnit.Framework;

namespace Program.UnitTests.Services
{
    [TestFixture]
    public class TelevisionTest
    {
        private Television? television;

        [SetUp]
        public void SetUp()
        {
            television = new Television();
        }

        [Test]
        public void IsOn_Return_False_On_Setup()
        {
            var result = television?.GetIsOn();

            Assert.IsFalse(result, "Should return false on setup");
        }

    }
}