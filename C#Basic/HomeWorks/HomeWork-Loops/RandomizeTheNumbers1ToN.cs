using System;

class RandomizeTheNumbers1ToN
{
    static void Main(string[] args)
    {
        Console.Write("Insert N :");
        int n = int.Parse(Console.ReadLine());
        
        Random a = new Random();
        for (int i = 0; i < n; i++)
        {
            int randNum = a.Next(n)+1;
            Console.Write("{0} ", randNum);
        }
        
    }
}

