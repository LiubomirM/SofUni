using System;

class DecimalToHexadecimalNumber
{
    static void Main()
    {
        long n = long.Parse(Console.ReadLine());
        string hexNum = null;
        char symbol = '0';
        for (long i = n; i > 0; i = i / 16)
        {
            long a = i % 16;
            if (a > 9)
            {
                
                switch(a)
                {
                    case 10: symbol = 'A'; break;
                    case 11: symbol = 'B'; break;
                    case 12: symbol = 'C'; break;
                    case 13: symbol = 'D'; break;
                    case 14: symbol = 'E'; break;
                    case 15: symbol = 'F'; break;
                }
                hexNum = symbol+hexNum;
            }
            else
            {
                hexNum = a+hexNum;
            }
        }
        Console.WriteLine(hexNum);
    }
}

