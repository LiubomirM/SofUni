using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        string[] input = Console.ReadLine().Split();
        string pattern = @"[\w\-\.]{1,}@[\w\-]{2,}\.[A-Za-z\.]{1,3}";
        Regex regex = new Regex(pattern);
        foreach (var item in input)
        {
            if (regex.IsMatch(item))
            {
                Console.WriteLine(item);
            }
        }
    }
}

