using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16.Comparing_floats
{
    class Program
    {
        static void Main(string[] args)
        {
            float numberA = float.Parse(Console.ReadLine());
            float numberB = float.Parse(Console.ReadLine());
            float difference = numberA - numberB;
            if (difference == 0 )
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }
        }
    }
}
