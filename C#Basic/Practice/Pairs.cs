using System;

class Pairs
{
    static void Main()
    {
        string n = Console.ReadLine();
        string[] num = n.Split();
        int[] numbers = new int[num.Length];
        int[] sum = new int[num.Length / 2];
        int counter = 1;
        int diff = 0;
        for (int i = 0; i < num.Length; i++)
        {
            numbers[i] =Convert.ToInt32(num[i]);
        }
        if (num.Length == 2)
        {
            if (numbers[0] == numbers[1])
            {
                Console.WriteLine("Yes, value={0}", numbers[0] + numbers[1]);
            }
            else
            {
                Console.WriteLine("No, maxdiff={0}", Math.Abs(numbers[0] - numbers[1]));
            }           
        }
        else
        {
            for (int i = 0, j = 0; i < num.Length; i+=2, j++)
            {
                sum[j] = numbers[i] + numbers[i + 1];
            }
            Array.Sort(sum);
            for (int i = 0; i < num.Length / 2 - 1; i++)
            {
                if (sum[i] == sum[i + 1])
                {
                    counter++;
                }
            }
            if (counter == num.Length / 2)
            {
                Console.WriteLine("Yes, value={0}", sum[0]);
            }
            else
            {
                diff = sum[num.Length / 2-1] - sum[0];
                Console.WriteLine("No, maxdiff={0}", diff);
            }
        }        
    }
}

