using System;

class PrimeNumberCheck
{
    static void Main()
    {
        Console.Write("Insert number: ");
        int number = int.Parse(Console.ReadLine());
        int kounter = 0;
        for (int i = 1; i <= number; i++)
        {
            if (number % i == 0)
            {
                kounter++;
            }
        }
        if (kounter == 2)
        {
            Console.WriteLine(true);
        }
        else
        {
            Console.WriteLine(false);
        }
    }
}

