using System;

class StringAndObjects
{
    static void Main()
    {
        string varOne = "Hellow";
        string varTwo = "World";
        object sumVar = varOne +" "+ varTwo;
        string text = (string)sumVar;
        Console.WriteLine(text);
    }
}

