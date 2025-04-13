using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Newtonsoft.Json;

namespace coding_challenges.Question3
{
    public class BillingAnalyzer
    {
        private List<DailyBilling> dailyBillings;

        public BillingAnalyzer(string jsonFilePath)
        {
            LoadBillingData(jsonFilePath);
        }

        private void LoadBillingData(string jsonFilePath)
        {
            var jsonData = File.ReadAllText(jsonFilePath);
            dailyBillings = JsonConvert.DeserializeObject<List<DailyBilling>>(jsonData);
        }

        public decimal GetMinBilling()
        {
            return dailyBillings.Where(b => b.Amount > 0).Min(b => b.Amount);
        }

        public decimal GetMaxBilling()
        {
            return dailyBillings.Max(b => b.Amount);
        }

        public int CountDaysAboveAverage()
        {
            var average = dailyBillings.Where(b => b.Amount > 0).Average(b => b.Amount);
            return dailyBillings.Count(b => b.Amount > average);
        }
    }

    public class DailyBilling
    {
        public DateTime Date { get; set; }
        public decimal Amount { get; set; }
    }
}