using System;
using System.Collections.Generic;
using System.Linq;

class Problem07Phonebook
{
    static void Main()
    {
        string input = Console.ReadLine();
        Dictionary<string, List<string>> phonebook = new Dictionary<string, List<string>>();
        do
        {
            string[] inputArray = input.Split('-');
            string name = inputArray[0];
            List<string> number = new List<string>();
            if (phonebook.ContainsKey(name))
            {
                number = phonebook[name];
                number.Add(inputArray[1]);
                phonebook[name] = number;
            }
            else
            {
                number.Add(inputArray[1]);
                phonebook.Add(name, number);
            }
            input = Console.ReadLine();

        } while (input != "search");

        while (true)
        {
        string search = Console.ReadLine();
            if (phonebook.ContainsKey(search))
            {
                foreach (string item in phonebook[search])
                {
                    Console.WriteLine("{0} -> {1}", search, item);
                }
            }
            else
            {
                Console.WriteLine("Contact {0} does not exist.", search);
            }
        }
    }
}

