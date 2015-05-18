using System;

class MatrixOfNumbers
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int m = n;
        int counter = 1;
        for (int row = 1; row <= n; row++)
        {          
            for (int col = counter ; col <= m; col++)
            {                
                Console.Write(col+" ");
            }
            counter++;
            m++;
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}

