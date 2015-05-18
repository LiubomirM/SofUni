using System;

class CrossingSequences
{
    static void Main()
    {
        int tribOne = int.Parse(Console.ReadLine());
        int tribTwo = int.Parse(Console.ReadLine());
        int tribThree = int.Parse(Console.ReadLine());
        int spiralStart = int.Parse(Console.ReadLine());
        int step = int.Parse(Console.ReadLine());
        int tribNum = 0;
        int spiralNum = spiralStart;
        int counter = step;
        int one = tribOne;
        int two = tribTwo;
        int three = tribThree;
        do
        {
            if (tribOne == spiralStart || tribTwo == spiralStart || tribThree == spiralStart || tribNum == spiralStart)
            {
                spiralNum = spiralStart;
                break;
            }
            else if (tribOne == spiralStart + step || tribTwo == spiralStart + step || tribThree == spiralStart + step || tribNum == spiralStart + step) 
            {
                spiralNum = spiralStart + step;
                break;
            }
            else if (one == spiralNum || two == spiralNum || three == spiralNum)
            {
                break;
            }
            else
            {
                tribNum = tribOne + tribTwo + tribThree;
                tribOne = tribTwo;
                tribTwo = tribThree;
                tribThree = tribNum;
                for (int i = 0; i < 2; i++)
                {
                    spiralNum += counter;
                    if (tribOne == spiralStart + step || tribTwo == spiralStart + step || tribThree == spiralStart + step || tribNum == spiralStart + step)
                    {
                        spiralNum = spiralStart + step;
                        break;
                    }
                    else if (one == spiralNum || two == spiralNum || three == spiralNum || tribNum == spiralNum)
                    {
                        break;
                    }
                }
                counter += step;
            }
        }
        while (tribNum != spiralNum && spiralNum <= 1000000);
        if (spiralNum <= 1000000) 
        {
            Console.WriteLine(spiralNum);
        }
        else
        {
            Console.WriteLine("No");
        }
    }
}

