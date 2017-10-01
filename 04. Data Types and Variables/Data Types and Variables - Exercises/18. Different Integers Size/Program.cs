using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18.Different_Integers_Size
{
    class Program
    {
        static void Main(string[] args)
        {
            long number = long.Parse(Console.ReadLine());
            string fitSbyte = null;
            string fitByte = null;
            string fitShort = null;
            string fitUshort = null;
            string fitInt = null;
            string fitUint = null;
            string fitLong = null;
            if (number >= -128 || number <= 127)
            {
                fitSbyte += "* sbyte";
            }
            else if (number == 0 || number <= 255)
            {

                fitByte += "* byte";
            }
            else if (number >= -32768 || number <= 32767)
            {
                fitSbyte += "* sbyte";
                fitByte += "* byte";
                fitShort += "* short";
            }
            else if (number == 0 || number <= 65535)
            {
                fitUshort += "* ushort";
            }
            else if (number >= -2147483648 || number <= 2147483647)
            {
                fitSbyte += "* sbyte";
                fitByte += "* byte";
                fitInt += "* int";
            }
            else if (number == 0 || number <= 4294967295)
            {
               fitUint += "* uint";
                fitByte += "* byte";
            }
            else if (number >= -9223372036854775808 || number <= 9223372036854775807)
            {
                fitSbyte += "* sbyte";
                fitLong += "* long";
            }
            else
            {
                Console.WriteLine("Can't fit in any type");
            }
        }
    }
}
