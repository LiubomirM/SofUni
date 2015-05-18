using System;

class PointInsideACircleAndOutsideOfARectangle
{
    static void Main(string[] args)
    {
        Console.Write("Insert X = ");
        double x = double.Parse(Console.ReadLine());
        Console.Write("Insert Y = ");
        double y = double.Parse(Console.ReadLine());
        double powR = Math.Pow((x-1), 2) + Math.Pow((y-1), 2);
        double powRCircle = 2.25;
        if (powR <= powRCircle && y>1)
        {
            Console.WriteLine(true);
        }
        else
        {
            Console.WriteLine(false);
        }
    }
}

