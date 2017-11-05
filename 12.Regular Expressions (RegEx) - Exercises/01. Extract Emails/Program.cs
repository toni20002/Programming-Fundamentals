using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _01.Extract_Emails
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            var matches =Regex.Matches(text, @"(?<=\s)[a-z0-9]+([-_.][a-z0-9]*)*@[a-z]+([.-][a-z]+)*(\.[a-z]+)");
            foreach (Match imatch in matches)
            {
                Console.WriteLine(imatch);
            }
        }
    }
}
