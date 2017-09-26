using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Calories_Counter
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfIngredients = int.Parse(Console.ReadLine());
            var calorieCounter = 0.00;
            for (int i = 0; i < numberOfIngredients; i++)
            {
                string ingredient = Console.ReadLine().ToLower();
                if (ingredient == "cheese")
                {
                    calorieCounter += 500;
                }
                if (ingredient == "tomato sauce")
                {
                    calorieCounter += 150;
                }
                if (ingredient == "salami")
                {
                    calorieCounter += 600;
                }
                if (ingredient == "pepper")
                {
                    calorieCounter += 50;
                }
            }
            Console.WriteLine("Total calories: {0}" ,calorieCounter);
        }
    }
}
