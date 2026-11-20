using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ass
{
    class Q61
    {
        public void show(int val)
        {
            val *= val;
            Console.WriteLine("Value after calling the function: " + val);
        }
        static void Main(string[] args) 
        {
            int val = 50;
            Q61 q = new Q61();
            Console.WriteLine("Value before calling the function: " + val);
            q.show(val);
            Console.ReadKey();
        }
    }
}

/* 
    Value before calling the function: 50
    Value after calling the function: 2500 
*/