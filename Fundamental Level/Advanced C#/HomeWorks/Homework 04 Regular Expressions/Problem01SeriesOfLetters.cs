using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

class Problem01SeriesOfLetters
{
    static void Main()
    {
        string input = Console.ReadLine();
        string pattern = @"([a-z])\1+";
        Regex regex = new Regex(pattern);
        MatchCollection matches = Regex.Matches(input, pattern);
        for (int i = 0; i < matches.Count; i++)
        {
            string temporaryPattern = matches[i].ToString();
            string replace = temporaryPattern.First().ToString();
            Regex tempRegex = new Regex(temporaryPattern);
            input = tempRegex.Replace(input, replace);
        }
        Console.WriteLine(input);
    }
}

