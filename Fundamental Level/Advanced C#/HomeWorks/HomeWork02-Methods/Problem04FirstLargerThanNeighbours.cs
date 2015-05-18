using System;
using System.Collections.Generic;
using System.Linq;

class Problem3LargerThanNeighbours
{
    static void Main()
    {
        string[] input = Console.ReadLine().Split();
        int[] numbers = new int[input.Length];
        for (int i = 0; i < input.Length; i++)
        {
            numbers[i] = Convert.ToInt32(input[i]);
        }
        bool isTrue = true;
        isTrue = GetIndexOfFirstElementLargerThanNeighbours(numbers, isTrue);
        if (isTrue)
        {
            Console.WriteLine("-1");
        }
    }

    private static bool GetIndexOfFirstElementLargerThanNeighbours(int[] numbers, bool isTrue)
    {
        for (int i = 0; i < numbers.Length; i++)
        {

            if (i == 0 && numbers[i] > numbers[i + 1])
            {
                Console.WriteLine(i);
                isTrue = false;
                break;
            }
            else if (i != 0 && numbers[i - 1] < numbers[i] && i == numbers.Length - 1)
            {
                Console.WriteLine(i);
                isTrue = false;
                break;
            }
            else if (i != 0 && numbers[i - 1] < numbers[i] && numbers[i] > numbers[i + 1] && i != numbers.Length - 1)
            {
                Console.WriteLine(i);
                isTrue = false;
                break;
            }
        }
        return isTrue;
    }
}



