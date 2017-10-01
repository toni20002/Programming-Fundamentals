using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.Integer_to_Hex_and_Binary
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int toBase = 16;
            int toBaseNew = 2;
            string convertedNumber = (string)(Convert.ToString(number, toBase));
            string convertedNumberNew = (string)(Convert.ToString(number, toBaseNew));
            string toUpper = convertedNumber.ToUpper();
            string toUpperNew = convertedNumberNew.ToUpper();
            Console.WriteLine(toUpper);
            Console.WriteLine(toUpperNew);
        }
    }
}
