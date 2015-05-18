using System;

class BitwiseExtractBitNumber3
{
    static void Main(string[] args)
    {
        Console.Write("Insert number: ");
        int n = int.Parse(Console.ReadLine());
        int nRight = n >> 3;
        int bit = nRight & 1;
        Console.WriteLine("Third bit is: "+bit);
    }
}

