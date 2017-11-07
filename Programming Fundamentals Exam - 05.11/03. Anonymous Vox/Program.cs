using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _03.Anonymous_Vox
{
    class Program
    {
        static void Main(string[] args)
        {
            string encodedText = Console.ReadLine();
            string placeHolders = Console.ReadLine().Split(new char[] { '{', '}' }, StringSplitOptions.RemoveEmptyEntries).ToString();
            var regex = @"([^a - z A - Z]+)|(.+)(\1)";
            var isMatch = Regex.Match(encodedText, regex);
            var matches = Regex.Matches(encodedText, @"([^a - z A - Z]+)|(.+)(\1)");
            for (int i = 0; i < encodedText.Length; i++)
            {
                if (encodedText[i] == encodedText.Length-1)
                {

                }
            }
            }
        }
    }
}
