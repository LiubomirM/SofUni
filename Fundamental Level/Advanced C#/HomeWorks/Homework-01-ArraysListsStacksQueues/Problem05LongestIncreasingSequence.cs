using System;
using System.Collections.Generic;
using System.Linq;

class Problem05LongestIncreasingSequence
{
    static void Main()
    {
        string[] inArr = Console.ReadLine().Split();
        int[] inputNums = new int[inArr.Length];
        for (int i = 0; i < inArr.Length; i++)
        {
            inputNums[i]=Convert.ToInt32(inArr[i]);
        }
        for (int i = 0; i < inArr.Length-1; i++)
        {
            if (inputNums[i] < inputNums[i + 1])
            {
                Console.Write(inputNums[i]+" ");
            }
            else 
            {
                Console.WriteLine(inputNums[i]);
            }
            if (i == inArr.Length-2)
            {
                Console.WriteLine(inputNums[i+1]);
            }
        }
    }
}

