using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ass
{
    class Q24
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a string: ");
            string str = Console.ReadLine();
            string rev = string.Empty;
            for (int i = str.Length - 1; i >= 0; i--)
            {
                rev += str[i];
            }
            Console.WriteLine("The reverse string is: " + rev);
            Console.ReadKey();
        }
    }
}

/* 
    Enter a string: jay
    The reverse string is: yaj
*/
