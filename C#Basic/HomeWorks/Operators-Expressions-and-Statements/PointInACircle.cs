using System;

class PointInACircle
{
    static void Main()
    {
        Console.Write("Insert X = ");
        double x = double.Parse(Console.ReadLine());
        Console.Write("Insert Y = ");
        double y = double.Parse(Console.ReadLine());
        double powR = Math.Pow(x, 2) + Math.Pow(y, 2);
        double powRCircle = 4;
        if (powR <= powRCircle)
        {
            Console.WriteLine(true);
        }
        else
        {
            Console.WriteLine(false);
        }
            
    }
}

