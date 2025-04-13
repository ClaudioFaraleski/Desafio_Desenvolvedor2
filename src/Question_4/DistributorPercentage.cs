public class DistributorPercentage
{
    public void Calculate()
    {
        var faturamento = new Dictionary<string, decimal>
        {
            { "SP", 67836.43m },
            { "RJ", 36678.66m },
            { "MG", 29229.88m },
            { "ES", 27165.48m },
            { "Outros", 19849.53m }
        };

        decimal total = faturamento.Values.Sum();

        foreach (var estado in faturamento)
        {
            decimal percentual = (estado.Value / total) * 100;
            Console.WriteLine($"Percentual de {estado.Key}: {percentual:F2}%");
        }
    }
}