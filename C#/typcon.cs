using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ass
{
    class Q53
    {
        static void Main(string[] args) 
        {
            string str = "100";
            int i1 = Convert.ToInt32(str);
            Console.WriteLine("Original value of str: " + str + " and converted value of i1: " + i1);

            i1 = int.Parse(str);
            Console.WriteLine("Original value of str: " + str + " and converted value of i1: " + i1);

            double d = 123.45;
            int i2 = Convert.ToInt32(d);
            Console.WriteLine("Original value of d: " + d + " and converted value of i2: " + i2);

            float f = 45.679f;
            string str2 = Convert.ToString(f);
            Console.WriteLine("Original value of f: " + f + " and converted value of str2: " + str2);

            bool i3 = true;
            string str1 = Convert.ToString(i3);
            Console.WriteLine("Original value of str: " + i3 + " and converted value of i3: " + str1);
            Console.ReadKey();
        }
    }
}

/* 
    Original value of str: 100 and converted value of i1: 100
    Original value of str: 100 and converted value of i1: 100
    Original value of d: 123.45 and converted value of i2: 123
    Original value of f: 45.679 and converted value of str2: 45.679
    Original value of str: True and converted value of i3: True
*/