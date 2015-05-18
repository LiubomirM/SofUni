using System;

class PiggyBank
{
    static void Main()
    {
        int tankPrice = int.Parse(Console.ReadLine());
        int partyDays = int.Parse(Console.ReadLine());
        double saveDays = 30-partyDays;
        double totalMonths = (tankPrice / (saveDays*2-partyDays*5));
        int total = Convert.ToInt32( Math.Ceiling(totalMonths));
        int years = total / 12;
        int months = total % 12;
        if ((saveDays * 2 - partyDays * 5) <= 0)
        {
            Console.WriteLine("never");
        }
        else
        {
            Console.WriteLine("{0} years, {1} months", years, months);
        }
        
    }
}

