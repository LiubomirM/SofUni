using System;

class ExtractBitFromInteger
{
    static void Main()
    {
        Console.Write("Insert number: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Insert bit index: ");
        int p = int.Parse(Console.ReadLine());
        int nRight = n >> p;
        int bit = nRight & 1;
        Console.WriteLine("Bit with index {0} is: {1}", p, bit);
    }
}

