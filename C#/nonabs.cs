using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ass
{
    abstract class Number 
    {
        public int Add(int a, int b) 
        {
            return a + b;
        }
    }
    class Derived : Number { }
    class Q72
    {
        static void Main(string[] args) 
        {
            Derived d = new Derived();
            Console.WriteLine("Addition: " + d.Add(7,2));
            Console.ReadKey();
        }
    }
}

/* 
    Addition: 9
*/