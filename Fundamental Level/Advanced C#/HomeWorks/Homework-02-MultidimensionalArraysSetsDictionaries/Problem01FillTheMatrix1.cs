using System;
using System.Collections.Generic;
using System.Linq;

class Problem01FillTheMatrix1
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            for (int j = 1; j <= n; j++)
            {
                if (j % 2 == 0)
                {
                    Console.Write(j * n - i + " ");
                }
                else
                {
                    Console.Write(i + (j-1)*n + 1 + " ");
                }
            }
            Console.WriteLine();
        }
    }
}

