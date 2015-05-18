using System;

class ExchangeVariableValues
{
    static void Main(string[] args)
    {
        int varA = 5;
        int varB = 10;
        Console.WriteLine("Before\n{0}\n{1}", varA, varB);
        int varC = varA+varB;
        varA = varB;
        varB = varC;
        Console.WriteLine("After\n{0}\n{1}", varA, varB);
    }
}

