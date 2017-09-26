using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangle_of_Dollars
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int row = 0; row < n; row++)
            {
                Console.Write('1',+1);
                for (int col = 0; col < row; col++)
                Console.Write("1");
                Console.WriteLine();
            }
        }
    }
}
