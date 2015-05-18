using System;
using System.Numerics;

class TrailingZeroesInNFactorial
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        BigInteger nFaktorial = 1;
        int zeroCounter = 0;
        for (int i = 1; i <= n; i++)
        {
            nFaktorial *= i;
        }
        while (nFaktorial % 10 == 0)
        {
            zeroCounter++;
            nFaktorial /= 10;
        }
        Console.WriteLine(zeroCounter);
    }
}

