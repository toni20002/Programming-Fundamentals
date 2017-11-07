using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _04.Anonymous_Cache
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> command = Console.ReadLine().Split(new char[] { ' ', '\t', '\n' } ,StringSplitOptions.RemoveEmptyEntries).ToList();
            Dictionary<string, Dictionary<string, int>> dataDic = new Dictionary<string, Dictionary<string, int>>();
            Dictionary<string, int> cache = new Dictionary<string, int>();

            var dataKeySizeSetPattern = @"\w+ \-\> \d{0,} \| \w+";
            var dataSetPattern = @"[A-Za-z]+";

            var startWithDataKey = Regex.IsMatch(command[0], dataKeySizeSetPattern);
            var startWithDataSet = Regex.IsMatch(command[0], dataSetPattern);

            string firstMatch = null;
            while (command[0] != "thetinggoesskrra")
            {
                if (startWithDataSet == true)
                {
                    try
                    {
                        dataDic.Add();
                    }
                    catch (Exception)
                    {

                        throw;
                    }
                    Data firstSet = new Data();
                    firstSet.dataSet = command[0];
                    dataDic.Add(firstSet.dataSet = command[0], new Dictionary<string, int>());
                    command = Console.ReadLine().Split(new char[] { ' ', '\t', '\n' } ,StringSplitOptions.RemoveEmptyEntries).ToList();
                }
                if (startWithDataKey == true)
                {
                    Data secondSet = new Data();
                    secondSet.dataKey = command[0];
                    secondSet.dataSize = int.Parse(command[1]);
                    try
                    {
                        secondSet.dataSet = command[2];
                    }
                    catch (Exception)
                    {
                        cache.Add(secondSet.dataKey = command[0], secondSet.dataSize = int.Parse(command[1]));
                    }
                }
                command = Console.ReadLine().Split(new char[] { ' ', '\t', '\n' }, StringSplitOptions.RemoveEmptyEntries).ToList();
            }
        }
        public class Data
        {
            public string dataKey { get; set; }
            public int dataSize { get; set; }
            public string dataSet { get; set; }
        }
    }
   
}
