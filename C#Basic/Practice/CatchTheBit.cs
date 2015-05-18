using System;
using System.Collections.Generic;
using System.Linq;

class CatchTheBit
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int step = int.Parse(Console.ReadLine());
        int[] number = new int[n];
        int bit;
        string bits = "";
        string bitsArray = "";
        for (int i = 0; i < n; i++)
        {
            number[i] = int.Parse(Console.ReadLine());
            for (int j = 0; j < 8; j++)
            {
                bit = (number[i] >> j) & 1;
                bits = Convert.ToString(bit) + bits;
            }
            bitsArray += bits;
            bits = "";
        }
        int bitCounter=0;
        string newBitsArray = "";
        for (int i = 1; i <= bitsArray.Length; i+=step)
        {
            newBitsArray += bitsArray.Substring(i, 1);
            bitCounter++;
        }
        int byteCounter = 0;
        for (int i = 1; i <= n; i++)
        {
            byteCounter = i;
            while (bitCounter < i * 8)
            {
                newBitsArray += 0;
                bitCounter++;
                
            }
            if (bitCounter % (i * 8) == 0)
            {
                break;
            }    
        }
        for (int i = 0; i < byteCounter; i++)
        {
            string bytes="";
            for (int j = i*8; j < 8 + i*8; j++)
            {
                bytes += newBitsArray.Substring(j,1);
            }
            int rezult = Convert.ToInt32(bytes, 2);
            Console.WriteLine(rezult);
        }
    }
}

