using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Cake_Ingredients
{
    class Program
    {
        static void Main(string[] args)
        {
            int ingredients = 0;
                for (;;)
                {
                string flavour = Console.ReadLine();
                if (flavour == "Bake!")
                {
                    Console.WriteLine("Preparing cake with {0} ingredients." ,ingredients);
                    break;
                }
                Console.WriteLine("Adding ingredient {0}." ,flavour);
                ingredients++;
                }
            }
        }
    }

