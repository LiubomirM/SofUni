using System;

class FourDigitNumber
{
    static void Main(string[] args)
    {
        Console.Write("Insert four digit number: ");
        int n = int.Parse(Console.ReadLine());
        while (1000<=n ^ n<10000)
         
        {
            Console.Write("Insert four digit number: ");
            int.TryParse(Console.ReadLine(), out n);
        }
        int firstDigitRest = n / 1000;
        int firstDigit = firstDigitRest % 10;

        int secondDigitRest = n / 100;
        int secondDigit = secondDigitRest % 10;

        int thirdDigitRest = n / 10;
        int thirdDigit = thirdDigitRest % 10;

        int fourthDigit = n % 10;

        int sumOfDigits = firstDigit + secondDigit + thirdDigit + fourthDigit;

        Console.WriteLine("Sum of digits = " + sumOfDigits);
        Console.WriteLine("Reversed: {0}{1}{2}{3}",fourthDigit,thirdDigit,secondDigit,firstDigit);
        Console.WriteLine("Last digit in front: {0}{1}{2}{3}",fourthDigit,firstDigit,secondDigit,thirdDigit);
        Console.WriteLine("Second and third digits exchanged: {0}{1}{2}{3}",firstDigit,thirdDigit,secondDigit,fourthDigit);
    }
}

