using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Choose_a_Drink_2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            string proffesionalist = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());
string drink = null;

            switch (proffesionalist)
            {
                case "Athlete":
                    Console.WriteLine("Water");
                    break;
                case "Businessman":
                    Console.WriteLine("Coffee");
                    break;
                case "Busineswoman":
                    Console.WriteLine("Coffee");
                    break;
                case "SoftUni Student":
                    Console.WriteLine("Beer");
                    break;
            }
            if (proffesionalist != "Athlete" && proffesionalist != "Businessman" && proffesionalist != "Businesswoman" && proffesionalist != "SoftUni Student")
            {
                Console.WriteLine("Tea");
            }

        
    }
    }
}
