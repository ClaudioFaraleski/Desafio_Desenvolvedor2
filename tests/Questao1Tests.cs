using NUnit.Framework;

namespace coding_challenges.tests
{
    [TestFixture]
    public class Question1Tests
    {
        private SumCalculator _sumCalculator;

        [SetUp]
        public void Setup()
        {
            _sumCalculator = new SumCalculator();
        }

        [Test]
        public void Calculate_WhenCalledWith13_Returns91()
        {
            // Arrange
            int indice = 13;

            // Act
            int result = _sumCalculator.Calculate(indice);

            // Assert
            Assert.AreEqual(91, result);
        }
    }
}