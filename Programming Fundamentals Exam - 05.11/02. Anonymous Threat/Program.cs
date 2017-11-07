using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Anonymous_Threat
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(new char[] { ' ', '\t', '\n' }).ToArray();
            var command = Console.ReadLine().Split();
            int startIndex = 0;
            int endIndex = 0;
            string concat = null;
            while (command[0] != "3:1")
            {
                startIndex = int.Parse(command[1]);
                    endIndex = int.Parse(command[2]);
                if (command.Contains("merge"))
                { 
                    
                    if (startIndex >= input.Length || endIndex >= input.Length)
                    {
                        var startIndex1 = input.First();
                        var startIndex2 = input.Last();
                        foreach (var str in input)
                        {
                            concat += str;

                        }
                        Console.WriteLine(concat);
                    }
                    var startValue =input.GetValue(startIndex);
                   var endValue = input.GetValue(endIndex);
                    for (int i = startIndex; i <= endIndex; i++)
                    {
                        concat += input[i];
                    }
                   // if (startIndex < 0 || endIndex < input.Length)
                   // {
                  //      break;
                   // }
                }
                if (command.Contains("divide"))
                {
                }
                command = Console.ReadLine().Split();
            }
        }

    }
}
