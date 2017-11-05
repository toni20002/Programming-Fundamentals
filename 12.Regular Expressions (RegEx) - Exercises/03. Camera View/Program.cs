using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _03.Camera_View
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> elements = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            string line = Console.ReadLine();
            var matches = Regex.Matches(line, @"(?<=\|\<)[A-za-z0-9]+");
            List<string> views = new List<string>();
            //elements[0] - to be skipped 
            //element[2] - to be taken
            var m = elements[0];
            var n = elements[1];
            foreach (Match match in matches)
            {
                var pictures = new string(match.Value.Skip(m).Take(n).ToArray());
                views.Add(pictures);
            }
            Console.WriteLine(string.Join(", ", views));
        }
    }
}
