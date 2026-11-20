using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ass
{
    class Q12
    {
        static void Main(string[] args)
        {
            int n;
            Console.Write("Enter any number: ");
            n = Convert.ToInt32(Console.ReadLine());
            if (n % 2 == 0)
            {
                Console.WriteLine(n + " is Even");
            }
            else
            {
                Console.WriteLine(n + " is Odd");                
            }
            Console.ReadKey();
        }
    }
}
/* 
    Enter any number: 25
    25 is Odd 
*/