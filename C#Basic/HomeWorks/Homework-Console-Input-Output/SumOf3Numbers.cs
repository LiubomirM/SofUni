using System;

class SumOf3Numbers
{
    static void Main()
    {
        Console.Write("Insert number: ");
        double numOne = double.Parse(Console.ReadLine());
        Console.Write("Insert number: ");
        double numTwo = double.Parse(Console.ReadLine());
        Console.Write("Insert number: ");
        double numThree = double.Parse(Console.ReadLine());
        double sum = numOne + numTwo + numThree;
        Console.WriteLine("Sum of numbers = "+sum);
    }
}

