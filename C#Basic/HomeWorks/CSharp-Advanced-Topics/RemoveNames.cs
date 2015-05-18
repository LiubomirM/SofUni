using System;
using System.Collections.Generic;
using System.Linq;


class RemoveNames
{
    static void Main()
    {
        string names = Console.ReadLine();
        string[] firstLine = names.Split();
        List<string> firstLineNames = firstLine.ToList<string>();
        string remNames = Console.ReadLine();
        string[] secondLine = remNames.Split();
        List<string> secondLineNames = secondLine.ToList<string>();
        for (int i = 0; i < secondLine.Length; i++)
        {
            while (firstLineNames.Contains(secondLineNames[i]))
            {
                firstLineNames.Remove(secondLineNames[i]);
            }
        }
        foreach (var name in firstLineNames)
        {
            Console.Write(name+' ');
        }
    }
}

