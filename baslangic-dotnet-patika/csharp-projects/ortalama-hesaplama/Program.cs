using System;
using System.Collections.Generic;

class FibonacciCalculator
{
    private Dictionary<int, long> cache = new Dictionary<int, long>();

    public long Calculate(int n)
    {
        if (cache.ContainsKey(n))
        {
            return cache[n];
        }
        else if (n <= 1)
        {
            return n;
        }
        else
        {
            long result = Calculate(n - 1) + Calculate(n - 2);
            cache[n] = result;
            return result;
        }
    }
}

class FibonacciApp
{
    static void Main()
    {
        FibonacciCalculator fibonacciCalculator = new FibonacciCalculator();

        int depth = GetUserInput();

        if (depth == 0)
        {
            Console.WriteLine("Derinlik 0 olduğu için hesaplama yapılamıyor.");
            return;
        }

        List<long> fibonacciNumbers = new List<long>();
        for (int i = 0; i < depth; i++)
        {
            fibonacciNumbers.Add(fibonacciCalculator.Calculate(i));
        }

        double average = (double)fibonacciNumbers.Sum() / depth;

        Console.WriteLine($"Fibonacci serisinin ilk {depth} elemanının ortalaması: {average:F2}");
    }

    static int GetUserInput()
    {
        while (true)
        {
            try
            {
                Console.Write("Fibonacci serisi için derinlik (pozitif bir tamsayı) girin: ");
                int depth = int.Parse(Console.ReadLine());

                if (depth < 0)
                {
                    Console.WriteLine("Lütfen pozitif bir tamsayı girin.");
                }
                else
                {
                    return depth;
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Geçersiz bir giriş. Lütfen bir tamsayı girin.");
            }
        }
    }
}