using System;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;

class Problem03CategorizeNumbers
{
    static void Main()
    {
        string input = Console.ReadLine();
        string[] inputArr = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        double[] numbresArr = new double[inputArr.Length];
        List<int> roundNum = new List<int>();
        List<double> floatNum = new List<double>();
        bool a = false;
        bool b = false;
        for (int i = 0; i < inputArr.Length; i++)
        {
            numbresArr[i] = Convert.ToDouble(inputArr[i]);
            if (numbresArr[i] % 1 == 0)
            {
                roundNum.Add(Convert.ToInt32(numbresArr[i]));
                a = true;
            }
            else
            {
                floatNum.Add(numbresArr[i]);
                b = true;
            }
        }

        if (b)
        {
            foreach (var item in floatNum)
            {
                Console.Write(item + " ");
            }
            Console.Write(" -> min: {0}, max: {1}, avg: {2:0.00}", floatNum.Min<double>(), floatNum.Max<double>(), floatNum.Average());
            Console.WriteLine();
        }
        if (a)
        {
            foreach (var item in roundNum)
            {
                Console.Write(item + " ");
            }
            Console.Write(" -> min: {0}, max: {1}, avg: {2:0.00}", roundNum.Min<int>(), roundNum.Max<int>(), roundNum.Average());
            Console.WriteLine();
        }       
    }
}

