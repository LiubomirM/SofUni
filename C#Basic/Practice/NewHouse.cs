using System;

class NewHouse
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n / 2; i++)
        {
            Console.WriteLine("{0}{1}{0}", new string('-',n/2-i), new string('*',2*i+1));
        }
        Console.WriteLine(new string('*', n));
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("{0}{1}{0}", new string('|', 1), new string('*', n-2));
        }
    }
}

