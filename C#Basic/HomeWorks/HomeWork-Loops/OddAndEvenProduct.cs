using System;

class OddAndEvenProduct
{
    static void Main()
    {
        string[] nums = Console.ReadLine().Split();
        int oddProd = 1;
        int evenProd = 1;
        for (int i = 0; i < nums.Length; i+=2)
        {
            oddProd *= Convert.ToInt32(nums[i]);           
        }
        for (int i = 1; i < nums.Length; i += 2)
        {
            evenProd *= Convert.ToInt32(nums[i]);
        }
        if (oddProd == evenProd)
        {
            Console.WriteLine("Yes\nProduct = "+oddProd);
        }
        else
        {
            Console.WriteLine("No\nOdd_product = {0}\nEven_product = {1}",oddProd,evenProd);
        }
    }
}

