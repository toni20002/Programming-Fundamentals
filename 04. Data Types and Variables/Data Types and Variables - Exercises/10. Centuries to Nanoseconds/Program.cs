using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Centuries_to_Nanoseconds
{
    class Program
    {
        static void Main(string[] args)
        {
            sbyte centuries = sbyte.Parse(Console.ReadLine());
            short years = (short)(centuries * 100.00);
            int days = (int)(years * 365.2422);
            int hours = days * 24;
            long minutes = hours * 60;
            long seconds = minutes * 60;
            long miliseconds = (long)seconds * 1000;
            ulong microseconds = (ulong)miliseconds * 1000;
            decimal nanoseconds = (decimal)microseconds * 1000;
            Console.WriteLine("{0} centuries = {1} years = {2} days = {3} hours = {4} minutes = {5} seconds = {6} milliseconds = {7} microseconds = {8} nanoseconds" ,centuries ,years ,days ,hours ,minutes ,seconds ,miliseconds ,microseconds ,nanoseconds);
        }
    }
}
