using System;

class CheckABitAtGivenPosition
{
    static void Main(string[] args)
    {
        Console.Write("Insert number: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Insert bit index: ");
        int p = int.Parse(Console.ReadLine());
        int nRight = n >> p;
        int bit = nRight & 1;
        bool a=(bit==1);
        Console.WriteLine(a);
    }
}

