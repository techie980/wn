using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ass
{
    class Q23
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number: ");
            int n = int.Parse(Console.ReadLine());
            int r, rev = 0;
            while (n > 0)
            {
                r = n % 10;
                rev = (rev * 10) + r;
                n = n / 10;
            }
            Console.WriteLine("The reverse order is: " + rev);
            Console.ReadKey();
        }
    }
}

/* 
    Enter the number: 123
    The reverse order is: 321 
*/