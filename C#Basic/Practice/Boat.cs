using System;

class Boat
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        
        for (int i = 0; i < n; i++)
        {
           
            if (i <= n/2)
            {
                Console.WriteLine("{0}{1}{2}", new string('.', n - 1- 2 * i),
                                               new string('*', i * 2 + 1), 
                                               new string('.', n));              
            }
            else
            {
                Console.WriteLine("{0}{1}{2}", new string('.', 2*i+1-n ), 
                                               new string('*', n - (2*i+1-n)), 
                                               new string('.', n));
            }            
        }
        for (int i = 0; i < n / 2; i++)
        {
            Console.WriteLine("{0}{1}{0}", new string('.',i),
                                           new string('*',2*n-2*i));
        }
    }
}

