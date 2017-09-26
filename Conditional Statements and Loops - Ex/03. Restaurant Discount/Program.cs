using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Restaurant_Discount
{
    class Program
    {
        static void Main(string[] args)
        {
            int groupSize = int.Parse(Console.ReadLine());
            string package = Console.ReadLine();
            string hall = null;
            double totalPrice = 0.00;
            if (groupSize <= 50)
            {
                hall = "Small Hall";
                totalPrice += 2500;
                Console.WriteLine("We can offer you the {0}" ,hall);

                if (package == "Normal")
                {
                    totalPrice = (totalPrice + 500.00);
                    totalPrice = totalPrice - ((5.00 / 100.00) * totalPrice);
                }
                else if (package == "Gold")
                {
                    totalPrice += 750;
                    totalPrice = totalPrice - ((10.00/100.00)*totalPrice);
                }
                else if (package == "Platinum")
                {
                    totalPrice += 1000;
                    totalPrice = totalPrice - ((15.00 / 100.00) * totalPrice);
                }
                Console.WriteLine("The price per person is {0:F2}$" ,(totalPrice/groupSize));
            }
            if (groupSize > 50 && groupSize <= 100)
            {
                hall = "Terrace";
                totalPrice += 5000;
                Console.WriteLine("We can offer you the {0}", hall);
                if (package == "Normal")
                {
                    totalPrice = (totalPrice + 500.00);
                    totalPrice = totalPrice - ((5.00 / 100.00) * totalPrice);
                }
                else if (package == "Gold")
                {
                    totalPrice += 750;
                    totalPrice = totalPrice - ((10.00 / 100.00) * totalPrice);
                }
                else if (package == "Platinum")
                {
                    totalPrice += 1000;
                    totalPrice = totalPrice - ((15.00 / 100.00) * totalPrice);
                }
                Console.WriteLine("The price per person is {0:F2}$", (totalPrice / groupSize));
            }
            if (groupSize > 100 && groupSize <= 120)
            {
                hall = "Great Hall";
                totalPrice += 7500;
                Console.WriteLine("We can offer you the {0}", hall);
                if (package == "Normal")
                {
                    totalPrice = (totalPrice + 500.00);
                    totalPrice = totalPrice - ((5.00 / 100.00) * totalPrice);
                }
                else if (package == "Gold")
                {
                    totalPrice += 750;
                    totalPrice = totalPrice - ((10.00 / 100.00) * totalPrice);
                }
                else if (package == "Platinum")
                {
                    totalPrice += 1000;
                    totalPrice = totalPrice - ((15.00 / 100.00) * totalPrice);
                }
                Console.WriteLine("The price per person is {0:F2}$", (totalPrice / groupSize));
            }
            else if (groupSize > 120)
            {
                Console.WriteLine("We do not have an appropriate hall.");
            }
        }
    }
}
