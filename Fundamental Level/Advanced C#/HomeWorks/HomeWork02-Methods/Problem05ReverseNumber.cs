using System;
using System.Collections.Generic;
using System.Linq;

class Problem05ReverseNumber
{
    static void Main()
    {
        double inputNumber = double.Parse(Console.ReadLine());
        GetReversedNumber(inputNumber);
    }

    private static void GetReversedNumber(double inputNumber)
    {
        string number = inputNumber.ToString();
        char[] numberToReverse = number.ToCharArray();
        Array.Reverse(numberToReverse);
        foreach (var symbol in numberToReverse)
        {
            Console.Write(symbol);
        }
    }
}

