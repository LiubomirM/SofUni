using System;

class CalculateGCD
{
    static void Main()
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int gsd = 0;
        for (int i = 1; i <= Math.Max(a, b); i++)
        {
            if (a % i == 0 && b % i == 0)
            {
                gsd = i;
            }
        }
        Console.WriteLine("GSD (a,b) = "+gsd);
    }
}

