using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.A_Miner_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            var resourceQuantity = new Dictionary<String, int>();

            string resource = Console.ReadLine();
            while (resource != "stop")
            {
                int quantity = int.Parse(Console.ReadLine());
                if (resourceQuantity.ContainsKey(resource))
                {
                    resourceQuantity[resource] += quantity;
                }
                else
                {
                    resourceQuantity[resource] = quantity;
                }
                resource = Console.ReadLine();
            }
            foreach (var x in resourceQuantity)
            {
                Console.WriteLine("{0} -> {1}", x.Key, x.Value);
            }
        }
    }
}
