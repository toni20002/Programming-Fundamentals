﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Debit_Card_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());
            int num4 = int.Parse(Console.ReadLine());
            Console.Write("{0} ", num1.ToString("D4"));
            Console.Write("{0} ", num2.ToString("D4"));
            Console.Write("{0} ", num3.ToString("D4"));
            Console.Write("{0}", num4.ToString("D4"));
            Console.WriteLine();
        }
    }
}
