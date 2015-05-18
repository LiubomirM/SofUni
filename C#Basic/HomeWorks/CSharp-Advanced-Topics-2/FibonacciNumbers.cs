using System;

class FibonacciNumbers
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        FibonacciNum(n);
    }

    private static void FibonacciNum(int n)
    {
        int a = 0;
        int b = 1;
        int c = 0;
        for (int i = 1; i <= n; i++)
        {
            c = a + b;
            a = b;
            b = c;            
        }
        Console.WriteLine(c);
    }
}


