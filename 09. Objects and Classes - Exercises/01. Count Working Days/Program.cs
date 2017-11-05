using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Count_Working_Days
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime startDate = DateTime.ParseExact(Console.ReadLine(), "dd-MM-yyyy", CultureInfo.InvariantCulture);
            DateTime endDate = DateTime.ParseExact(Console.ReadLine(), "dd-MM-yyyy" ,CultureInfo.InvariantCulture);
            DateTime[] officialHolidays =
            {
            DateTime.ParseExact("01-01-1970" , "dd-MM-yyyy" ,CultureInfo.InvariantCulture),
            DateTime.ParseExact("03-03-1970" , "dd-MM-yyyy" ,CultureInfo.InvariantCulture),
            DateTime.ParseExact("01-05-1970" , "dd-MM-yyyy" ,CultureInfo.InvariantCulture),
            DateTime.ParseExact("06-05-1970" , "dd-MM-yyyy" ,CultureInfo.InvariantCulture),
            DateTime.ParseExact("24-05-1970" , "dd-MM-yyyy" ,CultureInfo.InvariantCulture),
            DateTime.ParseExact("06-09-1970" , "dd-MM-yyyy" ,CultureInfo.InvariantCulture),
            DateTime.ParseExact("22-09-1970" , "dd-MM-yyyy" ,CultureInfo.InvariantCulture),
            DateTime.ParseExact("01-11-1970" , "dd-MM-yyyy" ,CultureInfo.InvariantCulture),
            DateTime.ParseExact("24-12-1970" , "dd-MM-yyyy" ,CultureInfo.InvariantCulture),
            DateTime.ParseExact("25-12-1970" , "dd-MM-yyyy" ,CultureInfo.InvariantCulture),
            DateTime.ParseExact("26-12-1970" , "dd-MM-yyyy" ,CultureInfo.InvariantCulture),
            };
            int workingDaysCounter = 0;
            for (DateTime date = startDate; date <= endDate; date = date.AddDays(1.0))
            {
                bool isNotHoliday = true;
                if (date.DayOfWeek != DayOfWeek.Saturday  && date.DayOfWeek != DayOfWeek.Sunday)
                {
                    foreach (var holiday in officialHolidays)
                    {
                        if (holiday.Day == date.Day && holiday.Month == date.Month)
                        {
                            isNotHoliday = false;
                            break;
                        }
                    }
                    if (isNotHoliday == true)
                    {
                        workingDaysCounter++;
                    }
                }
            }
            Console.WriteLine(workingDaysCounter);
        }
    }
}
