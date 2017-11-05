using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Magic_Exchangeable_Words
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ').ToArray();
            var firstWord = input[0].ToCharArray().Distinct().ToArray();
            var secondWord = input[1].ToCharArray().Distinct().ToArray();
            if (firstWord.Length == secondWord.Length)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }
        }
    }
}
