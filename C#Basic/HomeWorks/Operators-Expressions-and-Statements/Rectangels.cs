using System;

class Rectangels
{
    static void Main()
    {
        Console.Write("Insert width: ");
        double width = double.Parse(Console.ReadLine());
        Console.Write("Insert height: ");
        double height = double.Parse(Console.ReadLine());
        double perimeter = 2 * height + 2 * width;
        double area = height * width;
        Console.WriteLine("Perimeter is: {0}\nArea is: {1}",perimeter,area);
    }
}

