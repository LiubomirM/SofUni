using System;

class CheatSheet
{
    static void Main()
    {
        int rows = int.Parse(Console.ReadLine());
        int cols = int.Parse(Console.ReadLine());
        long startVer = int.Parse(Console.ReadLine());
        long startHor = int.Parse(Console.ReadLine());
        long[,] matrix = new long[rows, cols];
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                matrix[i, j] = (startVer + i) * (startHor + j);
                if (j != cols - 1)
                {
                    Console.Write("{0} ", matrix[i, j]);
                }
                else
                {
                    Console.Write(matrix[i,j]);
                }                
            }
            Console.WriteLine();
        }
    }
}

