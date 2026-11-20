using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ass
{
    class Q51
    {
        static void Main(string[] args) 
        {
            int n = 1500;
            Type t1 = n.GetType();
            double m = n;
            Type t2 = m.GetType();
            Console.WriteLine("Value of n: " + n);
            Console.WriteLine("Data Type of n: " + t1);
            Console.WriteLine("Integer Size: " + sizeof(int) + " Bytes");
            Console.WriteLine("Value of m: " + m);
            Console.WriteLine("Data Type of m: " + t2);
            Console.WriteLine("Double Size: " + sizeof(double) + " Bytes");
            Console.ReadKey();
        }
    }
}

/* 
    Value of n: 1500
    Data Type of n: System.Int32
    Integer Size: 4 Bytes
    Value of m: 1500
    Data Type of m: System.Double
    Double Size: 8 Bytes 
*/