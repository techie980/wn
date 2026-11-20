using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ass
{
    class Q146
    {
        static void Main(string[] args)
        {
            int n = 123;
            Object obj = n;
            try
            {
                int j = (short)obj;
                Console.WriteLine("Unboxing");
            }
            catch (InvalidCastException ex)
            {
                Console.WriteLine(ex.ToString());
            }
            Console.ReadKey();
        }
    }
}
/* 
    System.InvalidCastException: Specified cast is not valid.
    at Ass.Q146.Main(String[] args) in c:\Jay (C#)\Ass\Ass\Q146.cs:line 17 
*/