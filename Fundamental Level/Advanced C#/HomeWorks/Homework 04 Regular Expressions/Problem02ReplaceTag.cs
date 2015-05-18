using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

class Problem02ReplaceTag
{
    static void Main()
    {
        string input = Console.ReadLine();
        string pattern = @"<a (href=http:\/\/\w+\.\w+)>(\w+)<\/a>";
        Regex regex = new Regex(pattern);
        Match match = Regex.Match(input, pattern);
        string replace = "[URL " + match.Groups[1] + "]" + match.Groups[2] + "[/URL]";
        Console.WriteLine(Regex.Replace(input, pattern,replace));
    }
}

