using System;

class EncryptedMatrix
{
    static void Main()
    {
        string input = Console.ReadLine();
        string orientation = Console.ReadLine();
        char[] numbers;
        numbers = input.ToCharArray();
        string num = "0";
        for (int i = 0; i < input.Length; i++)
        {
            num += numbers[i] % 10;
        }
        num += "0";
        int[] nums = new int[num.Length];
        for (int i = 1; i < num.Length; i++)
        {
            nums[i] = Convert.ToInt32(num.Substring(i, 1));
        }
        string numArray = "";
        for (int i = 1; i < nums.Length-1; i++)
        {
            if (nums[i] % 2 == 0)
            {
                numArray += Convert.ToString(nums[i] * nums[i]);
            }
            else
            {
                numArray += Convert.ToString(nums[i - 1] + nums[i] + nums[i + 1]);
            }            
        }
        if (orientation == "\\")
        {
            for (int i = 0; i < numArray.Length; i++)
            {
                for (int j = 0; j < numArray.Length; j++)
                {
                    if (i == j)
                    {
                        Console.Write(numArray.Substring(i, 1) + " ");
                    }
                    else
                    {
                        Console.Write(0 + " ");
                    }
                }
                Console.WriteLine();
            }
        }
        else if (orientation == "/")
        {
            for (int i = 0; i < numArray.Length; i++)
            {
                for (int j = numArray.Length - 1; j >= 0; j--)
                {
                    if (i == j)
                    {
                        Console.Write(numArray.Substring(i, 1) + " ");
                    }
                    else
                    {
                        Console.Write(0 + " ");
                    }
                }
                Console.WriteLine();
            }
        }       
    }
}

