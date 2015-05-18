using System;
using System.Collections.Generic;
using System.Linq;

class Problem01FillTheMatrix
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        for (int i = 1; i <= n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write(i+n*j+" ");
            }
            Console.WriteLine();
        }
    }
}

