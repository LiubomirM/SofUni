using System;

class CalculateNumbers
{
    static void Main()
    {
        Console.WriteLine("Insert n: ");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("insert x: ");
        int x = int.Parse(Console.ReadLine());
        int factorial = 1;
        double s = 1;
        for (int i = 1; i <= n; i++)
        {
            factorial *= i;
            s += factorial / Math.Pow(x, i);
        }
        Console.WriteLine("S= {0:f5}",s);

    }
}

