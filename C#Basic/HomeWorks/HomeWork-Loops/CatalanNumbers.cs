using System;
using System.Numerics;

class CatalanNumbers
{
    static void Main()
    {
        Console.Write("Insert N: ");
        int n = int.Parse(Console.ReadLine());
        BigInteger nFactorial = 1;
        BigInteger doubleNFactorial = 1;
        BigInteger nPlusOneFactorial = 1;
        if (n < 0 || n > 99)
        {
            Console.WriteLine("\"N\" must be between 0 and 99!");
            return;
        }
        if (n == 0)
        {
            Console.WriteLine("Catalan (n) = 1");
        }
        else
        {
            for (int i = 1; i <= n; i++)
            {
                nFactorial *= i;
            }
            for (int i = 1; i <= 2 * n; i++)
            {
                doubleNFactorial *= i;
            }
            for (int i = 1; i <= n+1; i++)
            {
                nPlusOneFactorial *= i;
            }
            Console.WriteLine("Catalan (n) = {0}",doubleNFactorial/(nPlusOneFactorial*nFactorial));
        }
                                            
    }
}

