using System;
using System.Collections.Generic;
using System.Linq;

class Problem02MaximalSum
{
    static void Main()
    {
        string[] size = Console.ReadLine().Split();
        int rows = Convert.ToInt32(size[0]);
        int columns = Convert.ToInt32(size[1]);
        int[,] matrix = new int[rows, columns];
        for (int i = 0; i < rows; i++)
        {
            string[] stringRow = Console.ReadLine().Split();
            for (int j = 0; j < columns; j++)
            {
                matrix[i, j] = Convert.ToInt32(stringRow[j]);
            }
        }
        int possibleMatrices = (rows - 3 + 1) * (columns - 3 + 1);
        int[][,,] newMatrices =new int[possibleMatrices][,,];
        int[] sums = new int[possibleMatrices];
        int counter = 0;
        int countRows = 0;
        int countCol = 0;
        for (int i = 0; i < rows - 2; i++)
        {
            for (int j = 0; j < columns - 2; j++)
            {
                sums[counter] = matrix[i, j]     + matrix[i, j + 1]     + matrix[i, j + 2]
                            + matrix[i + 1, j] + matrix[i + 1, j + 1] + matrix[i + 1, j + 2]
                            + matrix[i + 2, j] + matrix[i + 2, j + 1] + matrix[i + 2, j + 2];

                newMatrices[counter] = new int[,,]{{{matrix[i, j],     matrix[i, j + 1],     matrix[i, j + 2]}},
                                                   {{matrix[i + 1, j], matrix[i + 1, j + 1], matrix[i + 1, j + 2]}},
                                                   {{matrix[i + 2, j], matrix[i + 2, j + 1], matrix[i + 2, j + 2]}}};
                counter++;
            }
        }
        int index = Array.IndexOf(sums,sums.Max());
        Console.WriteLine("Sum = {0}", sums.Max());
        List<int> outMatrix = new List<int>();
        foreach (var item in newMatrices[index])
        {
            outMatrix.Add(item);
        }
        for (int i = 1; i <= 9; i++)
        {
            Console.Write(outMatrix[i-1] + " ");
            if (i % 3 == 0)
            {
                Console.WriteLine();
            }
        }
    }
}

