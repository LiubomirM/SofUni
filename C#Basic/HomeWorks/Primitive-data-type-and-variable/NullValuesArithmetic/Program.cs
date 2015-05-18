using System;

class NullValuesArithmetic
{
    static void Main()
    {
        int? nullableInteger = null;
        double? nullableDouble = null;
        Console.WriteLine("nullableInteger = {0}\nnullableDouble = {1}", nullableInteger, nullableDouble);
        nullableInteger = 13;
        nullableDouble = 11.34;
        Console.WriteLine("Number + nullableInteger = {0}\nNumber + nullableDouble = {1}", nullableInteger, nullableDouble);
    }
}

