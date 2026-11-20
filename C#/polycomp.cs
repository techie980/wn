using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ass
{
    class Calculator
    {
        public int Add(int a, int b)
        {
            return a + b;
        }
        public int Add(int a, int b, int c)
        {
            return a + b + c;
        }
        public double Add(double a, double b)
        {
            return a + b;
        }
    }

    class Q121
    {
        static void Main(string[] args)
        {
            Calculator c = new Calculator();
            Console.WriteLine(c.Add(10, 20));
            Console.WriteLine(c.Add(10, 20, 30));
            Console.WriteLine(c.Add(10.5, 20.5));
            Console.ReadKey();
        }
    }
}

/* 
    30
    60
    31 
*/