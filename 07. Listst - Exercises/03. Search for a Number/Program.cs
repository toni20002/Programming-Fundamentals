using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Search_for_a_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            List<long> numbers = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(long.Parse)
                .ToList();
            long[] command = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(long.Parse)
                .ToArray();
            for (long i = 0; i < numbers.Count; i++)
            {
                command.Take((int)command[0]);
                numbers.RemoveRange((int)i, (int)command[1]);
                if (numbers.Contains(command[2]))
                {
                    Console.WriteLine("YES!");
                    break;
                }
                else
                {
                    Console.WriteLine("NO!");
                    break;
                }
            }
            //command[0] - numbers of elements we have to take from list
            //command[1] - numbers of elements we have to delete from list
            //command[2] - the number we are searching in the list
        }
    }
}
