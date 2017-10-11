using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Change_List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
            string command = Console.ReadLine();

            while (command != "Odd" && command != "Even")
            {
                string[] tokens = command.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();

                switch (tokens[0])
                {
                    case "Delete":
                        int replacer = int.Parse(tokens[1]);
                        for (int i = 0; i < numbers.Count; i++)
                        {
                            if (numbers[i] == replacer)
                            {
                                numbers.RemoveAt(i);
                                i--;
                            }
                        }
                        break;
                    case "Insert":
                        replacer = int.Parse(tokens[1]);
                        int position = int.Parse(tokens[2]);
                        numbers.Insert(position, replacer);
                        break;
                }
                command = Console.ReadLine();
            }
            foreach (var number in numbers)
            {
                if (number % 2 != 0 && command == "Odd")
                {
                    Console.Write(number + " ");
                }
                else if (number % 2 == 0 && command == "Even")
                {
                    Console.Write(number + " ");
                }
            }
        }
    }
}
