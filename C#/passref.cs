using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ass
{
    class Q62
    {
        public void show(ref int val)
        {
            val *= val;
            Console.WriteLine("Value after calling the function: " + val);
        }
        static void Main(string[] args) 
        {
            int val = 50;
            Q62 q = new Q62();
            Console.WriteLine("Value before calling the function: " + val);
            q.show(ref val);
            Console.ReadKey();
        }
    }
}
/* 
    Value before calling the function: 50
    Value after calling the function: 2500 
*/
