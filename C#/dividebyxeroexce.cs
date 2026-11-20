using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ass
{
    class Q145
    {
        static void Main(string[] args)
        {
            int n1 = 2, n2 = 0, n3;
            try
            {
                n3 = n1 / n2;
                Console.WriteLine("n3: " + n3);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.ToString());
            }
            Console.ReadKey();
        }
    }
}
/* 
    System.DivideByZeroException: Attempted to divide by zero.
    at Ass.Q145.Main(String[] args) in c:\Jay (C#)\Ass\Ass\Q145.cs:line 16 
*/