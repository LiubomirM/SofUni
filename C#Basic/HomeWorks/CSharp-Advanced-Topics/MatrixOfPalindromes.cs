using System;

class MatrixOfPalindromes
{
    static void Main()
    
    {
        int row = int.Parse(Console.ReadLine());
        int cow = int.Parse(Console.ReadLine());
        char a = 'a';
        char b = 'a';
        for (int i = 0; i < row; i++)
        {          
            for (int j = 0; j < cow; j++)
            {
                Console.Write("{0}{1}{0} ",a ,b);
                b++;
            }
            Console.WriteLine();           
            a++;
            b-=Convert.ToChar(cow-1);
        }
    }
}

