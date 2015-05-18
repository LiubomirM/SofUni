using System;

class Trapezoids
{
    static void Main(string[] args)
    {
        Console.Write("Insert a = ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Insert b = ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("insert h = ");
        double h = double.Parse(Console.ReadLine());
        double s = (a + b) * h / 2;
        Console.WriteLine("Trapezoid area is = {0}",s);
    }
}

