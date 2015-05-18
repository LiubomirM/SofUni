using System;

class FormattingNumbers
{
    static void Main()
    {
        Console.Write("Insert an integer number a (0...a...500): ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Insert b: ");
        float b = float.Parse(Console.ReadLine());
        Console.Write("Insert c: ");
        float c = float.Parse(Console.ReadLine());
        string aToBinary = Convert.ToString(a, 2).PadLeft(10, '0');
        Console.WriteLine("|{0,-10:X}|{1}|{2,10:#.##}|{3,-10:#.###}|",a,aToBinary,b,c);
    }
}

