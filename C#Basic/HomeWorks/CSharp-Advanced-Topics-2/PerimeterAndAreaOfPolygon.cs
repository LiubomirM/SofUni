using System;
using System.Collections.Generic;

class PerimeterAndAreaOfPolygon
{
    static void Main()
    {
        
        int n = int.Parse(Console.ReadLine());
        string[] value;
        List<string> xy = new List<string>();
        for (int i = 0; i < n; i++)
        {
            value = Console.ReadLine().Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);
            xy.Add(value);
        }
        
    }
}

