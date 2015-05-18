using System;

class DecimalToBinaryNumber
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        string b = null;
        for (int i = n, j=0; i > 0; i = i / 2, j++)
        {
            int[] a = new int[j + 1];
            a[j] = i % 2;
            b = Convert.ToString(a[j]) + b;            
        }
        Console.WriteLine(b);
    }
}

