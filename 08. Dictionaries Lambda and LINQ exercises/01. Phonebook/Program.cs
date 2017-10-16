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
            var phonebook = new Dictionary<string, string>();
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
                else
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
                input = Console.ReadLine();
            }

        }
    }
}
