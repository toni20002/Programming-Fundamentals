﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Interval_of_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());

            if (num1 >= num2)
            {
                while (num1 >= num2)
                {
                    Console.WriteLine(num2);
                    num2++;
                }
            }
            else
            { 
            while (num2 >= num1)
            {
                Console.WriteLine(num1);
                num1++;
            }
            }
        }
    }
}
