using System;

class NumbersInIntervalDividableByGivenNumber
{
    static void Main()
    {
        Console.Write("Start: ");
        int start = int.Parse(Console.ReadLine());
        Console.Write("End: ");
        int end = int.Parse(Console.ReadLine());
        int counter = 0;
        for (int i = start; i <= end; i++)
        {
           

                if (i % 5 == 0)
                {
                    counter++;
                }

         }
         Console.WriteLine("There are {0} numbers that are divisible by 5 without residue in the given interval.",counter);
    }
}

