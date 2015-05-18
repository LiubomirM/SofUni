using System;

class SumOfNNumbers
{
    static void Main()
    {
        Console.Write("Insert n= ");
        int n = int.Parse(Console.ReadLine());
        double sum = 0;
        for (int i = 0; i < n; i++)
        {
            sum += double.Parse(Console.ReadLine());
        }
        Console.WriteLine("Sum = "+sum);
    }
}

