using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Count_the_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int parsedNumber = 0;
            int counter = 0;
            for (int i = 1; i < 100; i++)
            {
                bool isNumber = Int32.TryParse(input, out parsedNumber);
                if (isNumber)
                {
                counter++;
                }
                else
                {
                break;
                }
                input = Console.ReadLine();
            }
            Console.WriteLine(counter);
        }
    }
}
