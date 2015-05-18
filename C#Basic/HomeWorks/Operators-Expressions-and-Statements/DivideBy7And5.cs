using System;

class DivideBy7And5
{
    static void Main()
    {
        Console.Write("Pleas insert number: ");
        int n = int.Parse(Console.ReadLine());
        bool a;
        a = (n % 5 == 0 && n % 7 == 0);
        if (a)
        {
            Console.WriteLine(true);
        }
        else
        {
            Console.WriteLine(false);
        }
    }
}

