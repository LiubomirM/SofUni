using System;
using System.Collections.Generic;
using System.Linq;

class LongestWordInAText
{
    static void Main()
    {
        string words = Console.ReadLine();
        string[] allWords = words.Split();
        int longestWordIndex = 0;
        for (int i = 1; i < allWords.Length; i++)
        {
            if (allWords[i].Length > allWords[longestWordIndex].Length)
            {
                longestWordIndex = i;
            }
        }

        Console.WriteLine(allWords[longestWordIndex]);
    }
}

