namespace VariousLittleCalculators;

public static class Factorials
{
    public static void Main()
    {
        // GetHighestFactorial(1000000);
        GetNLgNMaximum(1000000);
    }

    private static void GetNLgNMaximum(int ceiling)
    {
        var n = 1;
        var result = n * Math.Log2(n);
        while (result < ceiling)
        {
            n++;
            result = n * Math.Log2(n);
        }

        Console.WriteLine(n - 1);
    }

    public static int CalculateFactorial(int n)
    {
        if (n == 0) return 1;
        return n * CalculateFactorial(n - 1);
    }
    
    public static void GetHighestFactorial(int ceiling)
    {
        var currentFactorial = 1;
        var iterations = 0;
        
        while (currentFactorial < ceiling)
        {
            iterations++;
            currentFactorial = CalculateFactorial(iterations);
        }

        Console.WriteLine(iterations - 1);
    }
}