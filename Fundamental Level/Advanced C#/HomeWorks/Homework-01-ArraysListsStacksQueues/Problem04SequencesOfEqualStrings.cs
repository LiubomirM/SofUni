using System;
using System.Collections.Generic;
using System.Linq;

class Problem04SequencesOfEqualStrings
{
    static void Main()
    {

        List<string> input = Console.ReadLine().Split().ToList();
        do
        {
            int a = input.Count(p => p == input[0]);
            for (int j = 0; j < a; j++)
            {
                Console.Write(input[0]+" ");
            }
            string r = input[0];
            input.RemoveAll(p => p == r);
            Console.WriteLine();
        } while (input.Count > 0);
    }
}

