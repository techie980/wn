using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ass
{
    interface Printable
    {
        void Print();
    }
    interface Scannable
    {
        void Scan();
    }
    class Printer : Printable, Scannable
    {
        public void Print()
        {
            Console.WriteLine("Printing Document");
        }
        public void Scan()
        {
            Console.WriteLine("Scanning Document");
        }
    }
    class Q111
    {
        static void Main(string[] args)
        {
            Printer p = new Printer();
            p.Print();
            p.Scan();
            Console.ReadKey();
        }
    }
}

/* 
    Printing Document
    Scanning Document 
*/