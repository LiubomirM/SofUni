using System;

class DifferenceBetweenDates
{
    static void Main()
    {
        DateTime firstDate = DateTime.Parse(Console.ReadLine());
        DateTime secondDate = DateTime.Parse(Console.ReadLine());
        TotalDays(firstDate, secondDate);
    }

    private static void TotalDays(DateTime firstDate, DateTime secondDate)
    {
        TimeSpan days = secondDate - firstDate;
        double a = days.TotalDays;
        Console.WriteLine(a);
    }
}

