using System;

class Iliuminati
{
    static void Main()
    {
        string inputMessage = Console.ReadLine().ToUpper();
        string simbol;
        int vowelCounter = 0;
        int sum = 0;
        for (int i = 0; i < inputMessage.Length; i++)
        {
            simbol = inputMessage.Substring(i, 1);
            switch (simbol)
            {
                case ("A"): sum += 65; vowelCounter++; break;
                case ("E"): sum += 69; vowelCounter++; break;
                case ("I"): sum += 73; vowelCounter++; break;
                case ("O"): sum += 79; vowelCounter++; break;
                case ("U"): sum += 85; vowelCounter++; break;
            }
        }
        Console.WriteLine(vowelCounter);
        Console.WriteLine(sum);
    }
}

