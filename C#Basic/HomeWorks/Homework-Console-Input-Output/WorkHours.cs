using System;

class WorkHousrs
{
    static void Main()
    {
        int h = int.Parse(Console.ReadLine());
        int d = int.Parse(Console.ReadLine());
        int p = int.Parse(Console.ReadLine());
        double eficientWorkHour = (d - (d * 0.1)) * 12 * (p * 0.01);
        eficientWorkHour = (int)eficientWorkHour;
        if (eficientWorkHour < h)
        {
            eficientWorkHour -= h;
            Console.WriteLine("No");
            Console.WriteLine(eficientWorkHour);
        }
        else
        {
            eficientWorkHour -= h;
            Console.WriteLine("Yes");
            Console.WriteLine(eficientWorkHour);
        }
    }
}