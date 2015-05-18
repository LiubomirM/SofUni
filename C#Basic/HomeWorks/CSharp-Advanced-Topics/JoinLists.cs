using System;
using System.Collections.Generic;
using System.Linq;

class JoinLists
{
    static void Main()
    {
        string firstLine = Console.ReadLine();
        string secondLine = Console.ReadLine();
        string[] firstLineNums = firstLine.Split();      
        string[] secondLineNums = secondLine.Split();        
        List<string> list1 = firstLineNums.ToList<string>();
        List<string> list2 = secondLineNums.ToList<string>();
        List<string> all = list1.Concat(list2).Distinct().ToList();
        string[] allNums = all.ToArray();
        Array.Sort(allNums);
        foreach (var nums in allNums)
        {
            Console.Write(nums+' ');
        }
    }
}

