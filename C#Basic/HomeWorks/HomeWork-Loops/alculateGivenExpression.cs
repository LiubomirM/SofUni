using System;
using System.Numerics;

class alculateGivenExpression
{
    static void Main()
    {
        Console.Write("Insert n: ");
        int n = byte.Parse(Console.ReadLine());
        Console.Write("Insert k: ");
        int k = byte.Parse(Console.ReadLine());
        BigInteger nFactorial = 1;
        BigInteger kFactorial = 1;
        BigInteger nkFactorial = 1;
        int nkDiff = n - k;
        int diff = n - (n - k);
        if (n > 99)
        {
            Console.WriteLine("\"N\" must be smaller than 100!");
        }
        else
        {
            if (k >= n)
            {
                Console.WriteLine("\"K\" must be smaller than \"N\"!");
            }
            else
            {
                for (int i = 1; i <= n; i++)
                {
                    nFactorial *= i;
                    if (i <= diff)
                    {
                        kFactorial *= i;
                    }
                    if (i <= nkDiff)
                    {
                        nkFactorial *= i;
                    }
                }
                Console.WriteLine(nFactorial/(kFactorial*nkFactorial));
            }
        }
    }
}

