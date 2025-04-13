using NUnit.Framework;

namespace coding_challenges.tests
{
    [TestFixture]
    public class FibonacciCheckerTests
    {
        private FibonacciChecker _fibonacciChecker;

        [SetUp]
        public void Setup()
        {
            _fibonacciChecker = new FibonacciChecker();
        }

        [Test]
        [TestCase(0, ExpectedResult = "0 pertence à sequência de Fibonacci.")]
        [TestCase(1, ExpectedResult = "1 pertence à sequência de Fibonacci.")]
        [TestCase(2, ExpectedResult = "2 pertence à sequência de Fibonacci.")]
        [TestCase(3, ExpectedResult = "3 pertence à sequência de Fibonacci.")]
        [TestCase(5, ExpectedResult = "5 pertence à sequência de Fibonacci.")]
        [TestCase(8, ExpectedResult = "8 pertence à sequência de Fibonacci.")]
        [TestCase(13, ExpectedResult = "13 pertence à sequência de Fibonacci.")]
        [TestCase(4, ExpectedResult = "4 não pertence à sequência de Fibonacci.")]
        [TestCase(6, ExpectedResult = "6 não pertence à sequência de Fibonacci.")]
        [TestCase(7, ExpectedResult = "7 não pertence à sequência de Fibonacci.")]
        [TestCase(9, ExpectedResult = "9 não pertence à sequência de Fibonacci.")]
        [TestCase(10, ExpectedResult = "10 não pertence à sequência de Fibonacci.")]
        public string CheckFibonacci(int number)
        {
            return _fibonacciChecker.Check(number);
        }
    }
}