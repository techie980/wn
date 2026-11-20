using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ass
{
    class Q144
    {
        static void Main(string[] args)
        {
            string str = null;
            try
            {
                Console.WriteLine("The content of given string: " + str);
                Console.WriteLine(str.Substring(5));
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine(ex.ToString());
            }
            Console.ReadKey();
        }
    }
}
/* 
    The content of given string:
    System.NullReferenceException: Object reference not set to an instance of an object.
    at Ass.Q144.Main(String[] args) in c:\Jay (C#)\Ass\Ass\Q144.cs:line 17 
*/