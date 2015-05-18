using System;

class PlayWithIntDoubleAndString
{
    static void Main()
    {
        Console.WriteLine("Please choose a type:\n1-->Int\n2-->Double\n3-->String");
        int n = int.Parse(Console.ReadLine());
        if (n == 1)
        {
            Console.Write("Please enter a integer: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine(a+1);
        }
        else if (n == 2)
        {
            Console.Write("Please enter a double: ");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine(b+1);
        }
        else if (n == 3)
        {
            Console.Write("Please enter a string: ");
            string c = Console.ReadLine();
            Console.WriteLine("{0}*",c);
        }
        else
        {
            Console.WriteLine("Wrong choice!");
        }
    }
}

