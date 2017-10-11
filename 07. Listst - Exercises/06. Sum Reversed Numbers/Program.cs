using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Sum_Reversed_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
           
            Console.WriteLine(Reverse(numbers).Sum());
        }
        static List<int> Reverse(List<int> numbers)
        {
            List<int> reversedNumbers = new List<int>();
            foreach (var number in numbers)
            {
             var reversedNumbersAsChars = number.ToString().ToCharArray().Reverse().ToArray();
             reversedNumbers.Add(int.Parse(new string(reversedNumbersAsChars)));
            }
            return reversedNumbers;
        }
    }
}
