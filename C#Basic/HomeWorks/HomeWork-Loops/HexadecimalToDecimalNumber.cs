using System;

class HexadecimalToDecimalNumber
{
    static void Main()    
    {
        string n = Console.ReadLine();
        n = n.ToLower();
        long dec = 0;
        for (int i = n.Length - 1, j = 0; i >= 0; i--, j++)
        {
            char c = n[i];
            if (c >= 'a' && c <= 'z')
            {
                int num = 0;
                switch (c)
                {
                    case 'a': num = 10; break;
                    case 'b': num = 11; break;
                    case 'c': num = 12; break;
                    case 'd': num = 13; break;
                    case 'e': num = 14; break;
                    case 'f': num = 15; break;
                }
                dec += num * (int)Math.Pow(16, j);
            }
            else
            {
                dec += Convert.ToInt32(c.ToString()) * (int)Math.Pow(16, j);
            }
        }
        Console.WriteLine(dec);
    }
}

