public class FibonacciChecker
{
    public string Check(int number)
    {
        if (IsFibonacci(number))
        {
            return $"{number} pertence à sequência de Fibonacci.";
        }
        else
        {
            return $"{number} não pertence à sequência de Fibonacci.";
        }
    }

    private bool IsFibonacci(int number)
    {
        int a = 0, b = 1, c = 0;

        if (number == a || number == b)
        {
            return true;
        }

        while (c < number)
        {
            c = a + b;
            a = b;
            b = c;
        }

        return c == number;
    }
}