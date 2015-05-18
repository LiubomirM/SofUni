using System;

class CirclePerimeterAndArea
{
    static void Main()
    {
        Console.Write("Insert r = ");
        double radius =double.Parse(Console.ReadLine());
        double area = Math.PI * Math.Pow(radius, 2);
        double perimeter = Math.PI * 2 * radius;
        Console.WriteLine("Perimeter = {0:F2}\nArea = {1:F2}",perimeter,area);
    }
}

