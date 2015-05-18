using System;

class BasketBattle
{
    static void Main()
    {
        string f = Console.ReadLine();
        int n = int.Parse(Console.ReadLine());
        int[] score = new int[2];
        int[] round =new int[2];
        int a = 0;

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < 2; j++)
            {
                int p = int.Parse(Console.ReadLine());
                string I = Console.ReadLine();
                if (I == "success" && score[a] + p <= 500)
                {
                    score[a] += p;
                    round[a]++;
                }
                a++;
                if (a == 2)
                {
                    a = 0;
                }
            }
            if (score[0] == 500 && score[1] == 500)
            {
                Console.WriteLine("DRAW");
                Console.WriteLine(500);
                return;
            }
            if (score[0] == 500 || score[1] == 500)
            {
                break;
            }
            a = ((i + 1) % 2);
        }
        if (score[0] == 500 || score[1] == 500)
        {
            if (score[0] == 500)
            {
                Console.WriteLine(f);
                Console.WriteLine(round[0]);
                Console.WriteLine(score[1]);
            }
            else
            {
                if(f=="Simeon")
                {
                    Console.WriteLine("Nakov");
                    Console.WriteLine(round[1]);
                    Console.WriteLine(score[0]);
                }
                else
                {
                    Console.WriteLine("Simeon");
                    Console.WriteLine(round[1]);
                    Console.WriteLine(score[0]);
                }
            }
        }
        else if (score[0] == score[1])
        {
            Console.WriteLine("DRAW");
            Console.WriteLine(score[0]);
        }
        else
        {
            if (score[0] > score[1])
            {
                if (f == "Simeon")
                {
                    Console.WriteLine("Simeon");
                    Console.WriteLine(score[0]-score[1]);
                }
                else
                {
                    Console.WriteLine("Nakov");
                    Console.WriteLine(score[0]-score[1]);
                }
            }
            else
            {
                if (f == "Simeon")
                {
                    Console.WriteLine("Simeon");
                    Console.WriteLine(score[1]-score[0]);
                }
                else
                {
                    Console.WriteLine("Nakov");
                    Console.WriteLine(score[1]-score[0]);
                }
            }
        }
      
    }
}

