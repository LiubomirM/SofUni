using System;
using System.Collections.Generic;
using System.Linq;

class Problem04TextFilter
{
    static void Main()
    {
        string[] banList = Console.ReadLine().Split(',',' ');
        string[] inputText = Console.ReadLine().Split(',',' ');
        for (int i = 0; i < banList.Length; i++)
        {
            for (int j = 0; j < inputText.Length; j++)
            {
                if (banList[i]==inputText[j])
                {
                    string asterisks = null;
                    for (int k = 0; k < inputText[j].Length; k++)
			        {
			            asterisks += "*";
			        }
                    inputText[j] = asterisks;
                }
            }
        }
        foreach (var item in inputText)
        {
            Console.Write(item + " ");
        }
    }
}

