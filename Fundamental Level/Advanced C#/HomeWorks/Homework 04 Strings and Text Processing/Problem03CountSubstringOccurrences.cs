using System;
using System.Collections.Generic;
using System.Linq;

class Problem03CountSubstringOccurrences
{
    static void Main()
    {
        string input = Console.ReadLine().ToLower();
        string search = Console.ReadLine().ToLower();
        int counter = 0;
        for (int i = 0; i < input.Length - search.Length + 1; i++)
        {
            if (search == input.Substring(i, search.Length))
            {
                counter++;
            }
        }
        Console.WriteLine(counter);
    }
}


