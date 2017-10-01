using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17.Print_Part_Of_ASCII_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            short startingChar = short.Parse(Console.ReadLine());
            short endingChar = short.Parse(Console.ReadLine());
            for (int i = startingChar; i <= endingChar; i++)
            {
                Console.Write((char)i + " ");
            }
            Console.WriteLine();
        }
    }
}
