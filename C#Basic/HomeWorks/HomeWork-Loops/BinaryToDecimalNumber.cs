using System;

class BinaryToDecimalNumber
{
    static void Main()
    {
        string bin = Console.ReadLine();
        int[] n = new int[bin.Length];
        long decimalNum = 0;
        for (int i = bin.Length-1, j=0; i >= 0; i--,j++)
        {
            char character = bin[i];
            n[i] = Convert.ToInt32(character.ToString());
            decimalNum += (n[i] * Convert.ToInt32( Math.Pow(2, j)));                           
        }
        Console.WriteLine(decimalNum);
    }
}
