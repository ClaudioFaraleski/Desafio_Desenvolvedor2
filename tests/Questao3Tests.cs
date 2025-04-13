using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using Newtonsoft.Json.Linq;

namespace CodingChallenges.Tests
{
    [TestClass]
    public class Question3Tests
    {
        private BillingAnalyzer _billingAnalyzer;

        [TestInitialize]
        public void Setup()
        {
            _billingAnalyzer = new BillingAnalyzer();
        }

        [TestMethod]
        public void TestCalculateMinBilling()
        {
            var minBilling = _billingAnalyzer.CalculateMinBilling();
            Assert.AreEqual(0, minBilling); // Ajuste conforme os dados do billing.json
        }

        [TestMethod]
        public void TestCalculateMaxBilling()
        {
            var maxBilling = _billingAnalyzer.CalculateMaxBilling();
            Assert.AreEqual(10000, maxBilling); // Ajuste conforme os dados do billing.json
        }

        [TestMethod]
        public void TestCountDaysAboveAverage()
        {
            var daysAboveAverage = _billingAnalyzer.CountDaysAboveAverage();
            Assert.AreEqual(15, daysAboveAverage); // Ajuste conforme os dados do billing.json
        }
    }
}