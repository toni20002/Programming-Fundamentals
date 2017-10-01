using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Convert_Speed_Units
{
    class Program
    {
        static void Main(string[] args)
        {
            int distanceInMeters = int.Parse(Console.ReadLine());
            byte hours = byte.Parse(Console.ReadLine());
            byte minutes = byte.Parse(Console.ReadLine());
            byte seconds = byte.Parse(Console.ReadLine());
            int convertingVariableMS = (hours * 3600 +(minutes *60)+ seconds);
           float milesPerSecond = (float)distanceInMeters /convertingVariableMS;
            Console.WriteLine(milesPerSecond);
           float convertinVariableKM = (float)(milesPerSecond * 3.6);
            Console.WriteLine(convertinVariableKM);
            float convertingVariableMPH = (float)(convertinVariableKM / 1.609);
            Console.WriteLine(convertingVariableMPH);
        }
    }
}
