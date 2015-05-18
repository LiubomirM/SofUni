using System;
using System.Collections.Generic;

class PrimesInGivenRange
{
    static void Main()
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        FindPrimesInRange(a, b);
    }

    static List<int> FindPrimesInRange(int a, int b)
    {
        List<int> result = new List<int>();
        for (var i = a; i <= b; i++)
        {
            if (i < 2)
            {
                continue;
            }
            else
            {
                var isPrime = true;
                for (var j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime)
                {
                    result.Add(i);
                }
            }
            
        }
        foreach (var num in result)
        {
            Console.Write("{0}, ",num);            
        }
        return result;
    }
}

