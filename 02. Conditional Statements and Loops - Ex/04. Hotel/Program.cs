using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Hotel
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int nightsCount = int.Parse(Console.ReadLine());
            double studioApartment = 0;
            double doubleApartment = 0;
            double suiteApartment = 0;
            switch (month)
            {
                case "May":
                case "October":
                    studioApartment += 50*nightsCount;
                    doubleApartment += 65*nightsCount;
                    suiteApartment += 75*nightsCount;
                    break;
                case "June":
                case "September":
                    studioApartment += 60*nightsCount;
                    doubleApartment += 72*nightsCount;
                    suiteApartment += 82*nightsCount;
                    break;
                case "July":
                case "August":
                case "December":
                    studioApartment += 68*nightsCount;
                    doubleApartment += 77*nightsCount;
                    suiteApartment += 89*nightsCount;
                    break;
            }
            if (month == "May" || month == "October" && nightsCount > 7)
            {
                studioApartment = studioApartment - ((5.00/100.00)*studioApartment);
            }
            if (month == "June" || month == "September")
            {
                if (nightsCount > 14)
                {
                    doubleApartment = doubleApartment - ((10.00 / 100.00) * doubleApartment);
                }
            }
            if (month == "July" || month == "August" || month == "December")
            {
                if (nightsCount > 14)
                {
                    suiteApartment = suiteApartment - ((15.00 / 100.00) * suiteApartment);
                }
                
            }
            if (month == "October" && nightsCount > 7)
            {
                studioApartment = studioApartment / nightsCount * (nightsCount - 1);
            }
                if (month == "September" && nightsCount > 7)
            {
                studioApartment = studioApartment / nightsCount * (nightsCount - 1);
            }
            Console.WriteLine("Studio: {0:F2} lv." ,studioApartment);
            Console.WriteLine("Double: {0:F2} lv." ,doubleApartment);
            Console.WriteLine("Suite: {0:F2} lv." ,suiteApartment);
        }
}   }

