using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _02.Extract_Sentences_by_Keyword
{
    class Program
    {
        static void Main(string[] args)
        {
            string wordTosearch = Console.ReadLine();
            string textToBeSearched = Console.ReadLine();
            var matches = Regex.Matches(textToBeSearched , @"[^\.\!\?]*\b" + wordTosearch + @"\b[^\.\!\?]*");
            foreach (Match match in matches)
            {
                Console.WriteLine(match.Value.Trim());
            }
        }
    }
}
