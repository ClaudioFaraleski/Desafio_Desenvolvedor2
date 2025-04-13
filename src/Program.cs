using System;

namespace coding_challenges
{
    class Program
    {
        static void Main(string[] args)
        {
            // Chamada para a funcionalidade da Pergunta 1
            var sumCalculator = new Question1.SumCalculator();
            int indice = 13;
            int soma = sumCalculator.Calculate(indice);
            Console.WriteLine($"A soma dos números de 1 até {indice} é: {soma}");

            // Chamada para a funcionalidade da Pergunta 2
            var fibonacciChecker = new Question2.FibonacciChecker();
            int numberToCheck = 21; // Exemplo de número a ser verificado
            string fibonacciMessage = fibonacciChecker.Check(numberToCheck);
            Console.WriteLine(fibonacciMessage);

            // Chamada para a funcionalidade da Pergunta 3
            var billingAnalyzer = new Question3.BillingAnalyzer();
            billingAnalyzer.AnalyzeBillingData();

            // Chamada para a funcionalidade da Pergunta 4
            var distributorPercentage = new Question4.DistributorPercentage();
            distributorPercentage.Calculate();

            // Chamada para a funcionalidade da Pergunta 5
            var stringInverter = new Question5.StringInverter();
            string originalString = "Exemplo";
            string invertedString = stringInverter.Invert(originalString);
            Console.WriteLine($"A string invertida é: {invertedString}");
        }
    }
}