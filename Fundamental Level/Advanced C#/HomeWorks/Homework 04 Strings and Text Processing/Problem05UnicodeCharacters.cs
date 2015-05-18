using System;
using System.Collections.Generic;
using System.Linq;

class Problem05UnicodeCharacters
{
    static void Main()
    {
        string input = Console.ReadLine();
        foreach (var character in input)
        {
            Console.Write(@"\{0}", ((int)character).ToString("x4"));
        }
        Console.WriteLine();
    }
}

