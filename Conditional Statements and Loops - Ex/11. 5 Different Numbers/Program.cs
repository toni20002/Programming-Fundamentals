using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11._5_Different_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
            int magicNumber = int.Parse(Console.ReadLine());

            int sum = 0;
            int combinations = 0;

            for (int i = firstNum; i >= 1; i--)
            {
                for (int j = 1; j <= secondNum; j++)
                {
                    sum += 3 * (i * j);
                    combinations++;
                    if (sum >= magicNumber)
                    {
                        Console.WriteLine("{0} combinations" ,combinations);
                        Console.WriteLine("Sum: {0} >= {1}" ,sum ,magicNumber);
                        break;
                    }
                    
                    }
               if (sum >= magicNumber)
                    {
                        break;
                    } 
            }
            if (sum < magicNumber)
            {
                Console.WriteLine("{0} combinations" ,combinations);
                Console.WriteLine("Sum: {0}" ,sum);
            }
               
        }
    }
}
