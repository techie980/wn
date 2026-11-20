using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ass
{
    class Q148
    {
        static void Excep(int n)
        {
            Console.WriteLine(n);
            Excep(++n);
        }
        static void Main(string[] args)
        {
            try
            {
                Excep(0);
            }
            catch (OutOfMemoryException ex)
            {
                Console.WriteLine(ex.ToString());
            }
            Console.ReadKey();
        }
    }
}
/* Process is terminated due to StackOverflowException. */