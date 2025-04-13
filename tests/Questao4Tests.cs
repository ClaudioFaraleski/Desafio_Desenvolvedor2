using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Question4;

namespace coding_challenges.tests
{
    [TestClass]
    public class Question4Tests
    {
        [TestMethod]
        public void TestCalculateDistributorPercentage()
        {
            // Arrange
            var distributor = new DistributorPercentage();
            var expectedPercentages = new Dictionary<string, double>
            {
                { "SP", 41.96 },
                { "RJ", 22.57 },
                { "MG", 17.57 },
                { "ES", 16.90 },
                { "Outros", 12.00 }
            };

            // Act
            var actualPercentages = distributor.Calculate();

            // Assert
            foreach (var state in expectedPercentages.Keys)
            {
                Assert.AreEqual(expectedPercentages[state], actualPercentages[state], 0.01, $"Percentage for {state} is incorrect.");
            }
        }
    }
}