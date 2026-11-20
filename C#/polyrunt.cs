using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ass
{
    class Shape
    {
        public virtual void Draw()
        {
            Console.WriteLine("Drawing a Shape");
        }
    }
    class Cricle : Shape 
    {
        public override void Draw()
        {
            Console.WriteLine("Drawing a cricle");
        }
    }
    class Rectangle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Drawing a rectangle");
        }
    }
    class Q122
    {
        static void Main(string[] args)
        {
            Shape s;
            s = new Cricle();
            s.Draw();
            s = new Rectangle();
            s.Draw();
            Console.ReadKey();
        }
    }
}

/* 
    Drawing a cricle
    Drawing a rectangle 
*/