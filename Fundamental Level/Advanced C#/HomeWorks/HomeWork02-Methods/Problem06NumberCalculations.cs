using System;
using System.Collections.Generic;


class Problem06NumberCalculations
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        double[] numbers = new double[n];
        for (int i = 0; i < n; i++)
        {
            numbers[i] = double.Parse(Console.ReadLine());
        }

        double sum = 0;
        double product = 1;
        double average = 0;
        double maxValiue = double.MinValue;
        double minValiue = double.MaxValue;
        for (int i = 0; i < n; i++)
        {
            sum = Sum(numbers, sum, i);
            product = Product(numbers, product, i);
            maxValiue = MaxValue(numbers, maxValiue, i);
            minValiue = MinValue(numbers, minValiue, i);
        }
        average = Average(n, sum, average);
        Console.WriteLine("sum = " + sum);        
        Console.WriteLine("average = " + average);
        Console.WriteLine("maximum = " + maxValiue);
        Console.WriteLine("minimum = " + minValiue);
        Console.WriteLine("product = " + product);
    }

    private static double Average(int n, double sum, double average)
    {
        average = sum / n;
        return average;
    }

    private static double MinValue(double[] numbers, double minValiue, int i)
    {
        if (numbers[i] < minValiue)
        {
            minValiue = numbers[i];
        }
        return minValiue;
    }

    private static double MaxValue(double[] numbers, double maxValiue, int i)
    {
        if (numbers[i] > maxValiue)
        {
            maxValiue = numbers[i];
        }
        return maxValiue;
    }

    private static double Product(double[] numbers, double product, int i)
    {
        product *= numbers[i];
        return product;
    }

    private static double Sum(double[] numbers, double sum, int i)
    {
        sum += numbers[i];
        return sum;
    }

   
}

