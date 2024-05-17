using System;
using System.Numerics;


class Program
{
    static async Task Main(string[] args)
    { 
        Console.WriteLine("Calculating Factorial.... ");
        BigInteger factorialResult = await Task.Run(() => FactorialAsync(25));
        Console.WriteLine("Factorial of 25:" + factorialResult);

        Console.WriteLine("Calculating Fibonacci.... ");
        BigInteger fibonacciResult = await Task.Run(() => FibonacciAsync(25));
        Console.WriteLine("25th Fibonacci term: " + fibonacciResult);
    }

    static async Task<BigInteger> FactorialAsync(int n)
    {
        if (n == 0)
            return 1;
        else
        {
            BigInteger result = await Task.Run(() => FactorialAsync(n - 1));
            return n * result;
        }
    }

    static async Task<BigInteger> FibonacciAsync(int n)
    {
        if (n <= 1)
            return n;
        else
        {
            BigInteger term1 = await Task.Run(() => FibonacciAsync(n - 1));
            BigInteger term2 = await Task.Run(() => FibonacciAsync(n - 2));
            return term1 + term2;
        }
    }
}