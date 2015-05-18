using System;
using System.Collections.Generic;
using System.Linq;

class BitKiller
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int step = int.Parse(Console.ReadLine());
        int[] numbers = new int[n];
        int bin=0;
        string s = null;
        List<string> binary = new List<string>();
        for (int i = 0; i < n; i++)
        {
            string b = null;
            numbers[i] = int.Parse(Console.ReadLine());
            for (int j = 0; j < 8; j++)
            {
                bin = numbers[i] % 2;
                numbers[i] /= 2;                
                b = bin + b;
            }
            s += b;
        }
        for (int i = 0; i < 8 * n; i++)
        {
            binary.Add(Convert.ToString(s[i]));
        }
            for (int i = 1; i < binary.Count; i += step)
            {
                binary.RemoveAt(i);
                binary.Insert(i, "2");
            }
        while (binary.Contains("2"))
        {
            binary.Remove("2");
            binary.Add("0");
        }
        string[] dec = new string[n];
        int broi=0;        
        for (int i = 0; i < n; i++)
        {
            string aaa = null;
            for (int j = broi; j < 8 + broi; j++)
            {
                 aaa += binary[j];
            }
            dec[i] = aaa;
            broi += 8;
        }
        for (int i = 0; i < n; i++)
        {
            int deci = Convert.ToInt32(dec[i], 2);
            if (deci == 0)
            {
                continue;
            }
            else
            {
                Console.WriteLine(deci);
            }
        }       
    }
}

