using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Unicode_Characters
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            var finalResult = input.Select(x => string.Format(@"\u{0:x4}", Convert.ToUInt16(x))).ToList();
            foreach (var word in finalResult)
            {
                Console.Write(word);
            }
            Console.WriteLine();
        }
    }
}
