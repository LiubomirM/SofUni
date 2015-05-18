using System;
using System.Collections.Generic;
using System.Linq;

class Problem03MatrixShuffling
{
    static void Main()
    {
        int row = int.Parse(Console.ReadLine());
        int col = int.Parse(Console.ReadLine());
        string[,] matrix = new string[row, col];
        for (int i = 0; i < row; i++)
        {
            for (int j = 0; j < col; j++)
            {
                matrix[i, j] = Console.ReadLine();
            }
        }
        string[] command = Console.ReadLine().Split();
       
        while (command[0] != "END") 
        {
            int x1 = 0;
            int y1 = 0;
            int x2 = 0;
            int y2 = 0;
            try
            {
                x1 = Convert.ToInt32(command[1]);
                y1 = Convert.ToInt32(command[2]);
                x2 = Convert.ToInt32(command[3]);
                y2 = Convert.ToInt32(command[4]);
            }
            catch 
            {               
            }            
            bool trueCoordinates = false;
            if(x1 <= row && x2 <= row && y1 <= col && y2 <= col &&
               x1 >= 0   && x2 >= 0   && y1 >= 0   && y2 >= 0)
            {
                trueCoordinates = true;
            }
            
            if (command[0] == "swap" && command.Length == 5 && trueCoordinates)
            {
                string maskOfMatrix = matrix[x1, y1];
                matrix[x1, y1] = matrix[x2, y2];
                matrix[x2, y2] = maskOfMatrix;
                for (int i = 0; i < row; i++)
                {
                    for (int j = 0; j < col; j++)
                    {
                        Console.Write("{0} ",matrix[i,j]);
                    }
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("Invalid input!");
            }
            command = Console.ReadLine().Split();
        }
    }
        
}

