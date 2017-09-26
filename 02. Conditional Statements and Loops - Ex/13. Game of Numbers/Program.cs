using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.Game_of_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int magicNumber = int.Parse(Console.ReadLine());

            int newI = 0;
            int newJ = 0;
            int combinations = 0;
            bool isNumberFound = false;

            for (int i = firstNumber; i <= secondNumber; i++)
            {
                for (int j = firstNumber; j <= secondNumber; j++)
                {
                    combinations++;
                    if (i + j == magicNumber)
                    {
                        newI = i;
                        newJ = j;
                        isNumberFound = true;
                    }
                }
            }
            if (!isNumberFound)
            {
                Console.WriteLine("{0} combinations - neither equals {1}" ,combinations ,magicNumber);
            }
            else
            {
                Console.WriteLine("Number found! {0} + {1} = {2}" ,newI ,newJ ,magicNumber);  
            }
        }
    }
}
