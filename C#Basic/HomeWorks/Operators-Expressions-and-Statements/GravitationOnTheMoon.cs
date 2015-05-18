using System;

class GravitationOnTheMoon
{
    static void Main()
    {
        Console.Write("Inert your weight: ");
        double weight = double.Parse(Console.ReadLine());
        double moonWeight = weight * 0.17;
        Console.WriteLine("Your weight on the moon will be: {0}kg.",moonWeight);
    }
}
