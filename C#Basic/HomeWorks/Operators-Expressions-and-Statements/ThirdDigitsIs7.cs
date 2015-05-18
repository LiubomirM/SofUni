using System;

class ThirdDigitsIs7
{
    static void Main()
    {
        Console.Write("Insert number: ");
        double n = double.Parse(Console.ReadLine());
        double i = n / 100;
        double j = i % 10;
        if (j>=7 && j<8)
        {
            Console.WriteLine(true);
        }
        else
        {
            Console.WriteLine(false);
        }

    }
}

