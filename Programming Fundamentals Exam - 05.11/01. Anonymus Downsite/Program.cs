using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _01.Anonymus_Downsite
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger N = BigInteger.Parse(Console.ReadLine());
            BigInteger securityKey = BigInteger.Parse(Console.ReadLine());
            BigInteger totalLoss = 0;
            BigInteger countOfAffectedSites = 0;
            BigInteger securityToken = 0;
            List<string> affectedSites = new List<string>();
            for (BigInteger i = 0; i < N; i++)
            {
                if (N <= 0)
                {
                    break;
                }
                var dataAboutWebsites = Console.ReadLine().Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);
                var siteName = dataAboutWebsites[0];
                BigInteger siteVisits = BigInteger.Parse(dataAboutWebsites[1]);
                BigInteger siteCommercialPricePerVisit = BigInteger.Parse(dataAboutWebsites[2]);

                BigInteger siteLoss = BigInteger.Parse(dataAboutWebsites[1]) * BigInteger.Parse(dataAboutWebsites[2]);
                totalLoss += siteLoss;
                affectedSites.Add(siteName);
                countOfAffectedSites++;


            }
            foreach (var site in affectedSites)
            {
                Console.WriteLine(String.Join("", site));
            }
            Console.WriteLine("Total Loss: {0:f20}", totalLoss);
            securityToken = 1;
            for (BigInteger i = 0; i < countOfAffectedSites; i++)
            {
                securityToken = securityToken * securityKey;
            }
            Console.WriteLine("Security Token: {0}", securityToken);
        }
    }
}
