using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        string[] numbers = Console.ReadLine().Split();
        int[] number = new int[8];
        int row = 8;
        int cow = 12;
        int[,] matrix = new int[row,cow];
        string[] check;
        int [] checkNum=new int[3];
        int counter = 0;
        List<int> count = new List<int>();               
        do
        {
            for (int i = 0; i < 8; i++)
            {
                number[i] = Convert.ToInt32(numbers[i]);
                string num = null;
                int bin;              
                for (int j = 0; j < 12; j++)
                {
                    bin = number[i] % 2;
                    number[i] /= 2;
                    num = bin + num;
                    matrix[i, j] =Convert.ToInt32(bin);   
                }
            }
            
            check = Console.ReadLine().Split();
            if (check.Length == 2)
            {
                checkNum[1] = Convert.ToInt32(check[1]);
                for (int i = 0; i < 8; i++)
                {
                    if (matrix[i, checkNum[1]] == 1)
                    {
                        counter++;
                    }
                }
                count.Add(counter);
                counter = 0;
            }
            else if (check.Length == 3)
            {
                checkNum[0] = Convert.ToInt32(check[0]);
                checkNum[2] = Convert.ToInt32(check[2]);
                if (check[1] == "left")
                {
                    for (int i = 0; i < checkNum[2]; i++)
                    {
                        int mask = matrix[checkNum[0], 11];
                        matrix[checkNum[0], 11] = matrix[checkNum[0], 10];
                        matrix[checkNum[0], 10] = matrix[checkNum[0], 9];
                        matrix[checkNum[0], 9] = matrix[checkNum[0], 8];
                        matrix[checkNum[0], 8] = matrix[checkNum[0], 7];
                        matrix[checkNum[0], 7] = matrix[checkNum[0], 6];
                        matrix[checkNum[0], 6] = matrix[checkNum[0], 5];
                        matrix[checkNum[0], 5] = matrix[checkNum[0], 4];
                        matrix[checkNum[0], 4] = matrix[checkNum[0], 3];
                        matrix[checkNum[0], 3] = matrix[checkNum[0], 2];
                        matrix[checkNum[0], 2] = matrix[checkNum[0], 1];
                        matrix[checkNum[0], 1] = matrix[checkNum[0], 0];
                        matrix[checkNum[0], 0] = mask;                        
                    }
                    string decimalNum=null;
                    for (int j = 0; j < 12; j++)
                    {
                        decimalNum = matrix[checkNum[0], j] + decimalNum;
                    }
                    int newNum = Convert.ToInt32(decimalNum, 2);
                    
                }
                else if (check[1] == "right")
                {
                    for (int i = 0; i < checkNum[2]; i++)
                    {
                        int mask = matrix[checkNum[0], 0];
                        matrix[checkNum[0], 0] = matrix[checkNum[0], 1];
                        matrix[checkNum[0], 1] = matrix[checkNum[0], 2];
                        matrix[checkNum[0], 2] = matrix[checkNum[0], 3];
                        matrix[checkNum[0], 3] = matrix[checkNum[0], 4];
                        matrix[checkNum[0], 4] = matrix[checkNum[0], 5];
                        matrix[checkNum[0], 5] = matrix[checkNum[0], 6];
                        matrix[checkNum[0], 6] = matrix[checkNum[0], 7];
                        matrix[checkNum[0], 7] = matrix[checkNum[0], 8];
                        matrix[checkNum[0], 8] = matrix[checkNum[0], 9];
                        matrix[checkNum[0], 9] = matrix[checkNum[0], 10];
                        matrix[checkNum[0], 10] = matrix[checkNum[0], 11];
                        matrix[checkNum[0], 11] = mask;
                    }
                    string decimalNum = null;
                    for (int j = 0; j < 12; j++)
                    {
                        decimalNum = matrix[checkNum[0], j] + decimalNum;
                    }
                    int newNum = Convert.ToInt32(decimalNum, 2);
                    numbers[checkNum[0]] =Convert.ToString( newNum);                   
                }
            }
        }
        while (check[0] != "end");
        foreach (var num in count)
        {
            Console.WriteLine(num);
        }
        foreach (var nums in numbers)
        {
            Console.Write("{0} ", nums);
        }
        Console.WriteLine();              
    }
}

