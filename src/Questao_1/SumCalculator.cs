public class SumCalculator
{
    public int Calculate(int index)
    {
        int sum = 0;
        int k = 0;

        while (k < index)
        {
            k++;
            sum += k;
        }

        return sum;
    }
}