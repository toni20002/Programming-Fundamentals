using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Phonebook
{
    class Program
    {
        static void Main(string[] args)
        {
            var phonebook = new SortedDictionary<string, string>();
            string input = Console.ReadLine();

            while (input != "END")
            {
                string[] phonebookParametres = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                string command = phonebookParametres[0];
                if (command == "A")
                {
                    string key = phonebookParametres[1];
                    string value = phonebookParametres[2];
                    phonebook[key] = value;
                }
                else if (command == "S")
                {
                    string key = phonebookParametres[1];
                    if (phonebook.ContainsKey(key))
                    {
                        Console.WriteLine("{0} -> {1}", key, phonebook[key]);
                    }
                    else
                    {
                        Console.WriteLine("Contact {0} does not exist.", key);
                    }
                }
                else if (command == "ListAll")
                {
                    foreach (var contacts in phonebook)
                    {
                        Console.WriteLine("{0} -> {1}", contacts.Key, contacts.Value);
                    }
                }
                input = Console.ReadLine();
            }

        }
    }
}
