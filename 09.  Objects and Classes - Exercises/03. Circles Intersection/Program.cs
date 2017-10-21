using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03._Circles_Intersection
{
    class Program
    {
        static void Main(string[] args)
        {
            List<long> firstCircle = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(long.Parse)
                .ToList();
            List<long> secondCircle = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(long.Parse)
                .ToList();
            long x1 = 0;
            long x2 = 0;
            long y1 = 0;
            long y2 = 0;
            long r1 = 0;
            long r2 = 0;
            r1 = firstCircle[2];
            r2 = secondCircle[2];
            x1 = firstCircle[0];
            x2 = secondCircle[0];
            y1 = firstCircle[1];
            y2 = secondCircle[1];
            long distanceBetweenCircleCenters = Math.Abs(x1 - x2);
            if (distanceBetweenCircleCenters <= r1 + r2)
            {
                Console.WriteLine("Yes");
            }
            if (distanceBetweenCircleCenters > r1 + r2)
            {
                Console.WriteLine("No");
            }


        }
    }
}
