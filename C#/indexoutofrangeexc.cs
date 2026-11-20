using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ass
{
    class Q142
    {
        static void Main(string[] args)
        {
            try
            {
                int[] n = new int[5] {66, 23, 56, 11, 89};
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine("Element [{0}] = {1}", i, n[i]);
                }
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine(ex.ToString());
            }
            Console.ReadKey();
        }
    }
}
/* 
    Element [0] = 66
    Element [1] = 23
    Element [2] = 56
    Element [3] = 11
    Element [4] = 89
    System.IndexOutOfRangeException: Index was outside the bounds of the array.
       at Ass.Q142.Main(String[] args) in c:\Jay (C#)\Ass\Ass\Q142.cs:line 18 
*/