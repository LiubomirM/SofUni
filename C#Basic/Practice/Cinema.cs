using System;

class Cinema
{
    static void Main()
    {
        string kindOfMovie = Console.ReadLine();
        int rows = int.Parse(Console.ReadLine());
        int columns = int.Parse(Console.ReadLine());
        double numbersOfPeople = rows * columns;
        if (kindOfMovie == "Premiere")
        {
            double incomes = numbersOfPeople * 12;
            Console.WriteLine("{0:0.00} leva",incomes);
        }
        else if (kindOfMovie == "Normal")
        {
            double incomes = numbersOfPeople * 7.5;
            Console.WriteLine("{0:0.00} leva",incomes);
        }
        else
        {
            double incomes = numbersOfPeople * 5;
            Console.WriteLine("{0:0.00} leva",incomes);
        }
    }
}

