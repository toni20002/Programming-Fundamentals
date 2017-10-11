using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Max_Sequence_of_Equal_elements
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(new char[] { ' ' } , StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
            int start = 0;
            int length = 0;
            for (int i = 0; i < numbers.Count; i++)
            {
                start = numbers[i];
                length = numbers.Count;

            }
        }
    }
}
