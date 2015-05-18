using System;

class AddOrEvenInteger
{
    static void Main()
    {
        Console.WriteLine("Insert n:");
        int n = int.Parse (Console.ReadLine());
        Console.Write("Number \"n\" is Odd: ");
        bool a;
        a=(n % 2==0);
        if (a)
        {
            Console.WriteLine(false);
        }
        else
        {
            Console.WriteLine(true);
        }
        
    }
}

