using System;
using System.Numerics;

class CalculateNDividetK
{
    static void Main()
    {

        Console.Write("Insert n: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Insert k: ");
        int k = int.Parse(Console.ReadLine());
        BigInteger nFactorial = 1;
        BigInteger kFactorial = 1;
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

                }
                Console.WriteLine("n!/k! = {0}", nFactorial / kFactorial);
            }
        }
    }
}

