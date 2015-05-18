using System;
using System.Collections.Generic;
using System.Linq;

class Problem04SequenceInMatrix
{
    static void Main()
    {
        int row = int.Parse(Console.ReadLine());
        int col = int.Parse(Console.ReadLine());        
        string[,] matrix = new string[row, col];
        for (int i = 0; i < row; i++)
        {
            string[] input = Console.ReadLine().Split();
            for (int j = 0; j < col; j++)
            {
                matrix[i, j] = input[j];
            }
        }
        Result(row, col, matrix);
    }

    private static void Result(int row, int col, string[,] matrix)
    {
        string[] rowCheck = CheckRow(row, col, matrix);
        string[] colCheck = CheckCol(row, col, matrix);
        string[] diagCheck = CheckDiag(row, col, matrix);
        int max = Math.Max(Convert.ToInt32(rowCheck[0]), Math.Max(Convert.ToInt32(colCheck[0]), Convert.ToInt32(diagCheck[0])));
        
        for (int i = 0; i < max; i++)
        {
            if (max == Convert.ToInt32(rowCheck[0]))
            {
                Console.Write(rowCheck[1]);
            }
            else if (max == Convert.ToInt32(colCheck[0]))
            {
                Console.Write(colCheck[1]);
            }
            else
            {
                Console.Write(diagCheck[1]);
            }
            if (i + 1 < max)
            {
                Console.Write(", ");
            }
        }
        Console.WriteLine();
    }

    private static string[] CheckDiag(int row, int col, string[,] matrix)
    {
        int counter;
        int bestDiag = int.MinValue;
        string argumentDiag = null;
        for (int i = 0; i < row; i++)
        {
            counter = 1;
            for (int j = 0; j < col; j++)
            {
                if (j + 1 < col && i + j + 1 < row && matrix[i + j, j] == matrix[i + j + 1, j + 1])
                {
                    counter++;
                }
                if (counter > bestDiag)
                {
                    bestDiag = counter;
                    argumentDiag = matrix[i + j, j];
                }
            }
        }
        string[] diagCheck = new string[2];
        diagCheck [0] = Convert.ToString(bestDiag);
        diagCheck [1] = argumentDiag;
        return diagCheck;
    }

    private static string[] CheckCol(int row, int col, string[,] matrix)
    {
        int counter;
        int bestCol = int.MinValue;
        string argumentCol = null;
        for (int i = 0; i < col; i++)
        {
            counter = 1;
            for (int j = 0; j < row; j++)
            {
                if (j + 1 < row && matrix[j, i] == matrix[j + 1, i])
                {
                    counter++;
                }
                if (counter > bestCol)
                {
                    bestCol = counter;
                    argumentCol = matrix[j, i];
                }
            }
        }
        string[] colCheck = new string[2];
        colCheck[0] = Convert.ToString(bestCol);
        colCheck[1] = argumentCol;
        return colCheck;
    }

    private static string[] CheckRow(int row, int col, string[,] matrix)
    {
        int bestRow = int.MinValue;
        int counter;
        string argumentRow = null;
        for (int i = 0; i < row; i++)
        {
            counter = 1;
            for (int j = 0; j < col; j++)
            {
                if (j + 1 < col && matrix[i, j] == matrix[i, j + 1])
                {
                    counter++;
                }
                if (counter > bestRow)
                {
                    bestRow = counter;
                    argumentRow = matrix[i, j];
                }
            }
        }
        string[] rowCheck = new string[2];
        rowCheck [0] = Convert.ToString(bestRow);
        rowCheck [1] = argumentRow;
        return rowCheck;
    }
}

