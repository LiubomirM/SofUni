using System;
using System.Collections.Generic;

class Problem01ReverseString
{
    static void Main()
    {
        string input = Console.ReadLine();
        string output = null;
        for (int i = 0; i < input.Length; i++)
        {            
            output = input.Substring(i, 1) + output;           
        }
        Console.WriteLine(output);
    }
}

