using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Junior
{
    class Program
    {
        static void Main(string[] args)
        {
            byte a = 17;
            sbyte b = 3;
            short c = 4;
            ushort d = 5;
            int e = -6;
            uint f = 7;
            long g = -1000000000000000000;
            ulong h = 9000000000000000000;
            Console.WriteLine("Byte =" + Convert.ToString(a, 2) + ", SByte =" + Convert.ToString(b, 2));
            Console.WriteLine("Short =" + c + ", UShort =" + d);
            Console.WriteLine("Int =" + e + ", UInt =" + f);
            Console.WriteLine("Long =" + g + ", ULong =" + h);

        }
    }
}
