using System;

class PrimeChecker
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        IsPrime(n);      
    }

    private static void IsPrime(int n)
    {
        if (n == 0 || n == 1)
        {
            Console.WriteLine(false);
        }
        else
        {
            for (int i = 2; i <= n / 2; i++)
            {
                if (n % i == 0)
                {
                    Console.WriteLine(false);
                    continue;
                }
            }
            Console.WriteLine(true);
        }
    }
}
 
