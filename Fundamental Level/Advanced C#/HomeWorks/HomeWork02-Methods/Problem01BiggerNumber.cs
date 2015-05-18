using System;
using System.Collections.Generic;
using System.Linq;

class Problem01BiggerNumber
{
    static void Main()
    {
        int firstNumber = int.Parse(Console.ReadLine());
        int secondNumber = int.Parse(Console.ReadLine());
        Console.WriteLine(MaxNumber(firstNumber, secondNumber));
    }

    private static int MaxNumber(int firstNumber, int secondNumber)
    {
        int max = Math.Max(firstNumber, secondNumber);
        return max;
    }
}

