using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Choose_a_Drink
{
    class Program
    {
        static void Main(string[] args)
        {
            string proffesionalist = Console.ReadLine();
            uint quantity = uint.Parse(Console.ReadLine());
            string drink = null;
            switch (proffesionalist)
            {
                case "Athlete":
                    drink = "Water";
                    Console.WriteLine("The {0} has to pay {1:F2}.", proffesionalist, (0.70 * quantity));
                    break;
                case "Businessman":
                    drink = "Coffee";
                    Console.WriteLine("The {0} has to pay {1:F2}.", proffesionalist, (1.00 * quantity));
                    break;
                case "Businesswoman":
                    drink = "Coffee";
                    Console.WriteLine("The {0} has to pay {1:F2}.", proffesionalist, (1.00 * quantity));
                    break;
                case "SoftUni Student":
                    drink = "Beer";
                    Console.WriteLine("The {0} has to pay {1:F2}.", proffesionalist, (1.70 * quantity));
                    break;
            }
            if (proffesionalist != "Athlete" && proffesionalist != "Businessman" && proffesionalist != "Businesswoman" && proffesionalist != "SoftUni Student")
            {
                Console.WriteLine("The {0} has to pay {1:F2}.", proffesionalist, (1.20 * quantity));
            }

        }
    }
}
