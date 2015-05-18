using System;
using System.Collections.Generic;
using System.Linq;

class Problem06Palindromes
{
    static void Main()
    {
        string[] input = Console.ReadLine().Split(',','.','?','!',' ');
        List<string> palindromes = new List<string>();
        for (int i = 0; i < input.Length; i++)
        {
            int counter = 0;
            for (int j = 0, k=input[i].Length; j < input[i].Length; j++, k--)
            {
                if (input[i].Substring(j, 1) == input[i].Substring(k-1, 1))
                {
                    counter++;
                }
                if (counter == input[i].Length)
                {
                    palindromes.Add(input[i]);
                }
            }
        }
        palindromes.Sort();
        foreach (var words in palindromes)
        {
            Console.Write(words + ", ");
        }
        Console.WriteLine();
    }
}

