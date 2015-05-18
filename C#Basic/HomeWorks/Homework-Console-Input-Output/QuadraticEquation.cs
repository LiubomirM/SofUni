using System;

class QuadraticEquation
{
    static void Main()
    {
        Console.Write("Insert a= ");
        double a = float.Parse(Console.ReadLine());
        while (a == 0)
        {
            Console.WriteLine("\"a\", can not be 0");
            Console.Write("Insert a= ");
            double.TryParse(Console.ReadLine(),out a);
        }
        Console.Write("Insert b= ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("Insert c= ");
        double c = double.Parse(Console.ReadLine());
        double d = Math.Pow(b, 2) - (4 * a * c);
        if (d < 0)
        {
            Console.WriteLine("No real roots");
        }
        else if (d == 0)
        {
            double x = (-b / (2 * a));
            Console.WriteLine("X1 = X2 = " + x);
        }
        else
        {
            double x1 = (-b - Math.Sqrt(d)) / (2 * a);
            double x2 = (-b + Math.Sqrt(d)) / (2 * a);
            Console.WriteLine("X1 = " + x1);
            Console.WriteLine("X2 = " + x2);
        }
    }
}

