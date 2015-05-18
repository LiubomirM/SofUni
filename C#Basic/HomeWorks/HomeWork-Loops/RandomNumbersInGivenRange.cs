using System;

class RandomNumbersInGivenRange
{
    static void Main()
    {
        Console.Write("Insert N :");
        int n =int.Parse(Console.ReadLine());
        Console.Write("Insert MIN :");
        int min=int.Parse(Console.ReadLine());
        Console.Write("Insert MAX :");
        int max=int.Parse(Console.ReadLine());
        if (min >= max)
        {
            Console.WriteLine("MIN must be smaller than MAX!");
        }
        else
        {
            Random a = new Random();
            for (int i = 0; i < n; i++)
            {
                int randNum = a.Next(min,max+1);
                Console.Write("{0} ",randNum);
            }
        }
    }
}

