using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ass
{
    class Q147
    {
        static void Main(string[] args)
        {
            StringBuilder ab = new StringBuilder(17,17);
            try
            {
                ab.Insert(0, "World of C# Programming", 1);
                Console.WriteLine(ab.ToString());
            }
            catch (OutOfMemoryException ex)
            {
                Console.WriteLine(ex.ToString());
            }
            Console.ReadKey();
        }
    }
}
/* 
    System.OutOfMemoryException: Insufficient memory to continue the execution of the program.
    at System.Text.StringBuilder.Insert(Int32 index, String value, Int32 count)
    at Ass.Q147.Main(String[] args) in c:\Jay (C#)\Ass\Ass\Q147.cs:line 16
*/