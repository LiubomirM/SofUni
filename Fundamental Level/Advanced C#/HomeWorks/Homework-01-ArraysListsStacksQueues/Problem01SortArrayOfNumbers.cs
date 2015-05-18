using System;
using System.Collections.Generic;
using System.Linq;

class Problem01SortArrayOfNumbers
{
    static void Main()
    {
        string numbers = Console.ReadLine();
        string[] numArr = numbers.Split(new char[]{' '}, StringSplitOptions.RemoveEmptyEntries);
        int[] numberArr = new int[numArr.Length];
        for (int i = 0; i < numArr.Length; i++)
        {
            numberArr[i] = Convert.ToInt32(numArr[i]);
        }
        Array.Sort(numberArr);
        foreach (var num in numberArr)
        {
            Console.Write(num+" ");
        }
    }
}

