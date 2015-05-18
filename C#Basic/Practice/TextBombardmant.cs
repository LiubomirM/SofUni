using System;
using System.Collections.Generic;
using System.Linq;


class TextBombardmant
{
    static void Main()
    {
        string inText = Console.ReadLine();
        int width = int.Parse(Console.ReadLine());
        string bombs = Console.ReadLine();
        string[] bombPos = bombs.Split();
       
        List<char> text = inText.ToList<char>();
        int jumper = bombPos.Length;
        while (text.Count % width != 0)
        {
            text.Add(' ');
        }
        int counter = 0;
        for (int k = 0; k < text.Count; k++)
        {            
            for (int i = 0; i < text.Count; i++)
            {
                for (int j = 0; j < jumper; j++)
                {
                    if (i == Convert.ToInt32(bombPos[j]) && counter <= text.Count - width)
                    {
                        text.RemoveAt(i+counter);
                        text.Insert(i+counter, ' ');
                        
                    }
                }
            }
            counter+=width;
        }
            

        foreach (var character in text)
        {
            Console.Write(character);
        }
        Console.WriteLine();
    }
}

