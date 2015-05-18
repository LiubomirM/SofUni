using System;

class CheckForAPlayCard
{
    static void Main()
    {
        string a = Console.ReadLine();

        if (a == "2" || a == "3" || a == "4" || a == "5" || 
            a == "6" || a == "7" || a == "8" || a == "9" || 
            a =="10" || a == "A" || a == "J" || a == "Q" || a == "K")
        {
            Console.WriteLine("Yes");
        }
        else
        {
            Console.WriteLine("No");
        }
    }
}

