using System;


class SumOfElements
{
    static void Main()
    {
        Console.WriteLine("Insert integer numbers separated with space");
        string[] numbers = new string[0];
        int biggestNum = 0;
        int sum = 0;
        numbers = Console.ReadLine().Split();
        for (int i = 0; i < numbers.Length; i++)
        {
            if (biggestNum < Convert.ToInt32(numbers[i]))
            {
                biggestNum = Convert.ToInt32(numbers[i]);
            }
            sum += Convert.ToInt32(numbers[i]);
        }
        if (sum - biggestNum == biggestNum)
        {
            Console.WriteLine("Yes, sum=" + biggestNum);
        }
        else
        {
            Console.WriteLine("No, diff=" + Math.Abs(biggestNum - (sum - biggestNum)));
        }
    }
}


