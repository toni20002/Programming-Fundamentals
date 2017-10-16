using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Fix_Emails
{
    class Program
    {
        static void Main(string[] args)
        {
            var nameEmail = new Dictionary<string, string>();
            string name = Console.ReadLine();
            while (name != "stop")
            {
                string email = Console.ReadLine().ToLower();
                if (!email.EndsWith("uk") && !email.EndsWith("us"))
                {
                    nameEmail[name] = email;
                }
                name = Console.ReadLine();
            }
            foreach (var x in nameEmail)
            {
                Console.WriteLine("{0} -> {1}" ,x.Key ,x.Value);
            }
        }
    }
}
