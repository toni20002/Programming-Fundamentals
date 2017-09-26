using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Character_Stats
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int currHP = int.Parse(Console.ReadLine());
            int maxHp = int.Parse(Console.ReadLine());
            int currEnergy = int.Parse(Console.ReadLine());
            int maxEnergy = int.Parse(Console.ReadLine());

            Console.WriteLine("Name: {0}" ,name);
            Console.WriteLine("Health: |{0}{1}|", new string('|', currHP), new string('.', (maxHp - currHP)));
            Console.WriteLine("Energy: |{0}{1}|", new string('|', currEnergy), new string('.', (maxEnergy - currEnergy)));
        }
    }
}
