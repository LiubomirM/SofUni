﻿using System;

class Dumbell
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("{0}{1}{2}{1}{0}", new string('.',n-n/2-1), 
                                             new string('&',n/2+1),
                                             new string('.',n));
        for (int i = 0; i < n / 2 - 1; i++)
        {
            Console.WriteLine("{0}{1}{2}{1}{3}{1}{2}{1}{0}", new string('.',n/2-1-i),
                                                       new string('&',1),
                                                       new string('*',n/2+i),
                                                       new string('.',n));
        }
        Console.WriteLine("{0}{1}{0}{2}{0}{1}{0}", new string('&',1),
                                                         new string('*',n-2),
                                                         new string('=',n));
        for (int i = n / 2 - 2; i >= 0; i--)
        {
            Console.WriteLine("{0}{1}{2}{1}{3}{1}{2}{1}{0}", new string('.', n / 2 - 1 - i),
                                                       new string('&', 1),
                                                       new string('*', n / 2 + i),
                                                       new string('.', n));
        }
        Console.WriteLine("{0}{1}{2}{1}{0}", new string('.', n - n / 2 - 1),
                                             new string('&', n / 2 + 1),
                                             new string('.', n));
    }
}

