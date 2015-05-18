using System;

class MinMaxSumAndAverageOfNNumbers
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int [] number = new int [n];
        int sum = 0;
        int min = 0;
        int max = 0;
        for (int i = 0; i < n; i++)
        {
            number[i] =int.Parse(Console.ReadLine());
            sum += number[i];
        }
        min = number[0];
        max = number[0];
        for (int i = 0; i < n; i++)
        {
            if (min > number[i])
            {
                min = number[i];
            }
            if (max < number[i])
            {
                max = number[i];
            }
        }
        Console.WriteLine("Min = {0}\nMax = {1}",min,max);
        Console.WriteLine("Sum = "+sum);
        Console.WriteLine("Avg = {0:f2}",((double)sum/n));
    }
}

