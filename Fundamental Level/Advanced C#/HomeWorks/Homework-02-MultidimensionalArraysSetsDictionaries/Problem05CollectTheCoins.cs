using System;
using System.Collections.Generic;
using System.Linq;

class Problem05CollectTheCoins
{
    static void Main()
    {
        string[] inputArr = new string[4];
        for (int i = 0; i < inputArr.Length; i++)
        {
            inputArr[i] = Console.ReadLine();
        }
        int row = 0;
        int col = 0;
        int coinsCounter = 0;
        int hitsCounter = 0;
        string moveDirection = Console.ReadLine();
        foreach (char direction in moveDirection)
        {
            string currentString;
            char currentChar;
            switch (direction)
            {
                case 'V': row++;
                        if (row >= inputArr.Length || col >= inputArr[row].Length)
                        {
                            hitsCounter++;
                            row--;
                            break;
                        }
                        currentString = inputArr[row];
                        currentChar = currentString[col];
                        if (currentChar == '$')
                        {
                            coinsCounter++;
                        }
                break;

                case '^': row--;
                        if (row < 0 || col >= inputArr[row].Length)
                        {
                            hitsCounter++;
                            row++;
                            break;
                        }
                        currentString = inputArr[row];
                        currentChar = currentString[col];
                        if (currentChar == '$')
                        {
                            coinsCounter++;
                        }
                break;

                case '>': col++;
                        if (col >= inputArr[row].Length)
                        {
                            hitsCounter++;
                            col--;
                            break;
                        }
                        currentString = inputArr[row];
                        currentChar = currentString[col];
                        if (currentChar == '$')
                        {
                            coinsCounter++;
                        }
                break;

                case '<': col--;
                        if (col < 0)
                        {
                            hitsCounter++;
                            col++;
                            break;
                        }
                        currentString = inputArr[row];
                        currentChar = currentString[col];
                        if (currentChar == '$')
                        {
                            coinsCounter++;
                        }
                break;

                default: break;
            }
        }
        Console.WriteLine("Coins collected: {0}", coinsCounter);
        Console.WriteLine("Walls hit: {0}", hitsCounter);
    }
}

