using System;

class BankAccountData
{
    static void Main(string[] args)
    {
        string firstName = "Lubomir";
        string middleName = "Valentinov";
        string lastName = "Mladenov";
        decimal money = 63526.53m;
        string bankName = "Raiffeisen BANK";
        string iban = "BG32 RZBB 1234 5678 9098 76";
        long cardNumber1 = 1234567891235678;
        long cardNumber2 = 0876543212345687;
        long cardNumber3 = 5864361234567890;
        Console.WriteLine("{0} {1} {2}\nAvailable amount: {3} leva\n{4} IBAN: {5}\nCard number: {6}\nCard number: {7}\nCard number: {8}", firstName, middleName, lastName, money, bankName, iban, cardNumber1, cardNumber2, cardNumber3);
    }
}

