using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ass
{
    class Q22
    {
        static void Main(string[] args)
        {
            int n1 = 0, n2 = 1, n3, range;
            Console.Write("Enter the number upto which print the fibonacci series: ");
            range = int.Parse(Console.ReadLine());
            Console.Write(n1 + " " + n2 + " ");
            n3 = n1 + n2;
            for (int i = 2; n3 < range; i++)
            {
                Console.Write(n3 + " ");
                n1 = n2;
                n2 = n3;
                n3 = n1 + n2;
            }
            Console.ReadKey();
        }
    }
}
/* 
    Enter the number upto which print the fibonacci series: 7
    0 1 1 2 3 5     
*/