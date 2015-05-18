using System;

class SumOf5Numbers
{
    static void Main()
    {
 
      //  Console.WriteLine("Insert five numbers separated with space");
      //  string[] numbers = new string[5];
        double sum = 0;
        numbers = Console.ReadLine().Split();
        for (int i = 0; i < 5; i++)
        {
            sum += Convert.ToDouble(numbers[i]);
        }
        Console.WriteLine("Sum = "+sum);
    }
}

