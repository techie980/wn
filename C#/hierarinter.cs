using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ass
{
    interface Domestic
    {
        void Sound();
    }
    class Cat : Domestic
    { 
        public void Sound()
        {
            Console.WriteLine("Cat Meow");
        }
    }
    class Cow : Domestic
    {
        public void Sound()
        {
            Console.WriteLine("Cow Meos");
        }
    }
    class Q112
    {
        static void Main(string[] args)
        {
            Cat c = new Cat();
            c.Sound();
            Cow Co = new Cow();
            Co.Sound();
            Console.ReadKey();
        }
    }
}

/* 
    Cat Meow
    Cow Meos
*/