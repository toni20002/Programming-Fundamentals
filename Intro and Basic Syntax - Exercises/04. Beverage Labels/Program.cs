using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Beverage_Labels
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int mlDrink = int.Parse(Console.ReadLine());
            int kcal = int.Parse(Console.ReadLine());
            int sugarContent = int.Parse(Console.ReadLine());

            Console.WriteLine("{0}ml {1}:" ,mlDrink , name);
            Console.WriteLine("{0}kcal, {1}g sugars" , ((mlDrink/100.00)*kcal) , ((mlDrink/100.00)*sugarContent));
        }
    }
}
