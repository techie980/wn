using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ass
{
    abstract class Area 
    {
        abstract public int CalArea();
    }

    class Square : Area 
    {
        int s = 0;
        public Square(int n) 
        {
            s = n;
        }
        public override int CalArea() 
        {
            return s * s;
        }
    }
    class Q71
    {
        static void Main(string[] args) 
        {
            Square sq = new Square(6);
            Console.WriteLine("Area of Square: " + sq.CalArea());
            Console.ReadKey();
        }
    }
}

/* 
    Area of Square: 36
*/