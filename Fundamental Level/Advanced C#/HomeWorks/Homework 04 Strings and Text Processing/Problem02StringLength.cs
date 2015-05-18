using System;
using System.Collections.Generic;
using System.Linq;

class Problem02StringLength
{
    static void Main()
    {
        string input = Console.ReadLine();
        int a = input.Length;
        if (input.Length > 20)
        {
            Console.WriteLine(input.Substring(0,20));
        }
        else 
        {
            for (int i = 0; i < 20 - a; i++)
            {
                input += "*";
            }
            Console.WriteLine(input);
        }
    }
}

