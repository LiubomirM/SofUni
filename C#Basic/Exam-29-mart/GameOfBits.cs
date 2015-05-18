using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class GameOfBits
{
    static void Main()
    {
        uint n = uint.Parse(Console.ReadLine());
        string commands;
        int bb = 32;
        int counter = 0;


        do
        {
            commands = Console.ReadLine();
            counter = 0;
            uint bit = 0;
            string bits = "";
            int start = 0;
            int jump = 2;
            if (commands == "Odd")
            {
                start = 0;
            }
            else if (commands == "Even")
            {
                start = 1;
            }
            else if (commands == "Game Over!")
            {
                jump = 1;
            }
            if (bb == 1)
            {
                break;
            }
            for (int i = start; i < bb; i += jump)
            {
                bit = (n >> i) & 1;
                if (bit == 1)
                {
                    counter++;
                }
                bits = Convert.ToString(bit) + bits;
            }
            bb /= 2;

            n = Convert.ToUInt32(bits, 2);

            
        }
        while (commands != "Game Over!");

        Console.WriteLine("{0} -> {1}", n, counter);
    }
}

