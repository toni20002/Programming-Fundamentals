using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _01.Convert_from_Base_10_to_Base_N
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split(' ').ToList();
            var base10Num = BigInteger.Parse(numbers[0]);
            var baseNnum = BigInteger.Parse(numbers[1]);
            var fkfk = new List<BigInteger>();

            while (baseNnum != 0)
            {
                var temporary = baseNnum % base10Num;
                baseNnum /= base10Num;
                fkfk.Insert(0, temporary);
            }
            Console.WriteLine(string.Join("", fkfk));
        }
    }
}
