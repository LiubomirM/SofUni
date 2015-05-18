using System;

class FibonacciNumbers
{
    static void Main()
    {
        Console.WriteLine("Insert an integer:");
        int n = int.Parse(Console.ReadLine());
        uint x1 = 0;
        uint x2 = 1;

        if (n == 1)
        {
            Console.WriteLine(0);
            return;
        }  
        Console.Write("{0} {1} ", x1, x2);
        for (int i = 2; i < n; i++)
        {
            uint x3 = x1 + x2;
            Console.Write("{0} ", x3);
            x1 = x2;
            x2 = x3;
        }      
    }
}

