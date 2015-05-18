using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

class Problem04SentenceExtractor
{
    static void Main()
    {
        string keyWord = Console.ReadLine();
        string input = Console.ReadLine();
        string pattern = @"\b[^.?!]+\b"+keyWord+@"\b.*?[!.?]";
        Regex regex = new Regex(pattern);
        MatchCollection matches = Regex.Matches(input, pattern);
        foreach (var match in matches)
        {
            Console.WriteLine(match);
        }
    }
}

