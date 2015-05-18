using System;

class NumbersFrom1ToN
{
    static void Main()
    {
        Console.Write("Insert n= ");
        int n = int.Parse(Console.ReadLine());
        for (int i = 1; i <= n; i++)
        {
            Console.WriteLine(i);
        }
    }
}

