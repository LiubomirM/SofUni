using System;
using System.Collections.Generic;
using System.Linq;

class Problem06CountSymbols
{
    static void Main()
    {
        string input = Console.ReadLine();
        HashSet<char> symbols = new HashSet<char>(input);
        List<char> charList = symbols.ToList<char>();
        charList.Sort();       
        int counter = 0;
        for (int i = 0; i < charList.Count; i++)
        {
            counter = 0;
            for (int j = 0; j < input.Length; j++)
            {
                if (charList[i]==Convert.ToChar(input.Substring(j,1)))
                {
                    counter++;
                    
                }
            }
            Console.WriteLine("{0}: {1}", charList[i], counter);
        }
    }
}

