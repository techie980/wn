using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ass
{
    public class Animals
    {
        public void eat()
        {
            Console.WriteLine("Eating...");            
        }
    }
    public class Dogs : Animals
    {
        public void Bark()
        {
            Console.WriteLine("Barking...");
        }
    }
    public class Puppy : Dogs
    {
        public void Weep()
        {
            Console.WriteLine("Weeping...");
        }
    }
    class Q102
    {
        static void Main(string[] args)
        {
            Puppy p = new Puppy();
            p.eat();
            p.Bark();
            p.Weep();
            Console.ReadKey();
        }
    }
}
/* 
    Eating...
    Barking...
    Weeping... 
*/