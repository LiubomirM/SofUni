using System;
using System.Collections.Generic;
using System.Linq;

class Problem06SubsetSums
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        string[] nums = Console.ReadLine().Split();
        int[] numArr = new int[nums.Length];
        for (int i = 0; i < nums.Length; i++)
        {
            numArr[i] = Convert.ToInt32(nums[i]);
        }
        for (int i = 0; i < nums.Length; i++)
        {
            for (int j = i; j < nums.Length; j++)
            {
                if (n == numArr[i] + numArr[j])
                {
                    Console.WriteLine("{0} + {1} = {2}", numArr[i], numArr[j], n);
                }
            }
        }
    }
}

