using System;

class Program
{
    static long Fibonacci(int n)
    {
        if (n < 3)
            return 1;
        else
            return Fibonacci(n - 1) + Fibonacci(n - 2);
    }

    static void Main(string[] args)
    {
        for (int i = 1; i < 17; i++)
            Console.Write("{0}, ", Fibonacci(i));
        Console.WriteLine("...");
    }
}
true  const +-*/-= 123 0.5 0xFF  tewdfas <> /> <tag>