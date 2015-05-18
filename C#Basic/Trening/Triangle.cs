using System;

class Triangle
{
    static void Main()
    {
        short Ax = short.Parse(Console.ReadLine());
        short Ay = short.Parse(Console.ReadLine());
        short Bx = short.Parse(Console.ReadLine());
        short By = short.Parse(Console.ReadLine());
        short Cx = short.Parse(Console.ReadLine());
        short Cy = short.Parse(Console.ReadLine());

        double a = Math.Sqrt(Math.Pow((Ax - Bx), 2) + Math.Pow((Ay - By), 2));
        double b = Math.Sqrt(Math.Pow((Ax - Cx), 2) + Math.Pow((Ay - Cy), 2));
        double c = Math.Sqrt(Math.Pow((Bx - Cx), 2) + Math.Pow((By - Cy), 2));

        if (a + b > c && a + c > b && b + c > a)
        {
            double p = (a + b + c) / 2;
            double area = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            Console.WriteLine("Yes");
            Console.WriteLine("{0:0.00}",area);
        }
        else
        {
            Console.WriteLine("No");
            Console.WriteLine("{0:0.00}",a);
        }
    }
}

