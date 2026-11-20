using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ass
{
    class Q63
    {
        public void show(out int val)
        {
            int s = 5;
            val = s;
            val *= val;
        }
        static void Main(string[] args) 
        {
            int val = 50;
            Q63 q = new Q63();
            Console.WriteLine("Value passing before out variable: " + val);
            q.show(out val);
            Console.WriteLine("Value after receiving out variable: " + val);
            Console.ReadKey();
        }
    }
}

/*
    Value passing before out variable: 50
    Value after receiving out variable: 25 
*/