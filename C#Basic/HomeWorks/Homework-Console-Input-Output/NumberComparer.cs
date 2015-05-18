using System;

class NumberComparer
{
    static void Main()
    {
        Console.Write("Insert a: ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Insert b: ");
        double b = double.Parse(Console.ReadLine());
        double c = Math.Max(a, b);
        Console.WriteLine("Greater number is: "+c);
    }
}
