using System;

class QuotesInStrings
{
    static void Main()
    {
        string quotes1 = "The \"use\" of quotations causes difficulties.";
        string quotes2 = @"The ""use"" of quotations causes difficulties.";
        Console.WriteLine(quotes1 + "\n" + quotes2);
    }
}

