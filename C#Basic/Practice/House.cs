using System;

class House
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("{0}{1}{0}", new string('.',n/2), new string('*',1));
        for (int i = 0; i < n / 2-1; i++)
        {
            Console.WriteLine("{0}{1}{2}{1}{0}", new string('.',n/2-i-1),
                                                 new string('*',1),
                                                 new string('.',i*2+1));
        }
        Console.WriteLine(new string('*',n));
        for (int i = 0; i < n/2-1; i++)
        {
            Console.WriteLine("{0}{1}{2}{1}{0}", new string('.', n/4),
                                                 new string('*', 1),
                                                 new string('.',n-n/4*2-2));
        }
        Console.WriteLine("{0}{1}{0}", new string('.', n/4), new string('*',n-n/4*2));
    }
}

