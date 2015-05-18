using System;

class HalfSum
{
    static void Main()
    {
       
       int n=int.Parse(Console.ReadLine());
       int sum = 0;
       for (int i = 0; i < n; i++) 
       {
           int num = int.Parse(Console.ReadLine());
           sum = sum + num;
       }
       int newSum = 0;
       for (int i = 0; i < n; i++)
       {
           int newNum = int.Parse(Console.ReadLine());  
           newSum = newSum + newNum;
       }
       if (sum == newSum)
       {
           int a = sum + newSum;
           Console.WriteLine("Yes, sum= "+a);
       }
       else
       {
           int b = Math.Abs(sum - newSum);
           Console.WriteLine("No, diff= " + b);
       }
    }
}

