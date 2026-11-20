using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ass
{
    class Q92
    {
        public int Calculation(int x, int y)
        {
            int val = x * y;
            return val;
        }
        static void Main(string[] args) 
        {
            Q92 q = new Q92();
            Console.WriteLine(q.Calculation(10,12));
            Console.ReadKey();
        }
    }
}

/* 120 */