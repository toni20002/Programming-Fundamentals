using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Miles_to_Kilometers
{
    class Program
    {
        static void Main(string[] args)
        {
            double milesToConvert = double.Parse(Console.ReadLine());
            Console.WriteLine("{0:F2}" , (milesToConvert*1.60934));
        }
    }
}
