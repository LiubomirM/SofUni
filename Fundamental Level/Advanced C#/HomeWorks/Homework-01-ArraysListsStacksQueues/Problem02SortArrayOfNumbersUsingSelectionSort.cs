using System;
using System.Collections.Generic;
using System.Linq;

class Problem02SortArrayOfNumbersUsingSelectionSort
{
    static void Main()
    {
        string input = Console.ReadLine();
        string[] inputArr = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        int[] numbresArr = new int[inputArr.Length];
        int num = 0;
        bool move;
        for (int i = 0; i < inputArr.Length; i++)
        {
            numbresArr[i] = Convert.ToInt32(inputArr[i]);
        }
        do
        {
            move = false;
            for (int i = 0; i < numbresArr.Length - 1; i++)
            {
                if (numbresArr[i] > numbresArr[i + 1])
                {
                    num = numbresArr[i];
                    numbresArr[i] = numbresArr[i + 1];
                    numbresArr[i + 1] = num;
                    move = true;
                }
            }
        } while (move);
        foreach (var nums in numbresArr)
        {
            Console.Write(nums+" ");
        }
    }
}

