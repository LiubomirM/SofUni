using System;

class ModifyABitAtGivenPosition
{
    static void Main()
    {
        Console.Write("Insert number: ");
        int n = int.Parse(Console.ReadLine());

        Console.Write("Insert bit index: ");
        int p = int.Parse(Console.ReadLine());

        Console.Write("Insert a bit value (0/1): ");
        int v = int.Parse(Console.ReadLine());
        
        if (v == 1)
        {
            int mask = 1 << p;
            int newBit = n | mask;
            Console.WriteLine("New number is: "+newBit);
            Console.WriteLine(Convert.ToString(n, 2).PadLeft(16, '0'));
            Console.WriteLine(Convert.ToString(newBit, 2).PadLeft(16, '0'));
        }
        else
        {
            int mask = ~(1<<p);
            int newBit = n & mask;
            Console.WriteLine("New number is: "+newBit);
            Console.WriteLine(Convert.ToString(n, 2).PadLeft(16, '0'));
            Console.WriteLine(Convert.ToString(newBit, 2).PadLeft(16, '0'));

        }
    }
}

