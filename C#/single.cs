using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ass
{
    public class Animal
    {
        public void eat()
        {
            Console.WriteLine("Eating...");
        }
    }
    public class Dog : Animal
    {
        public void bark()
        {
            Console.WriteLine("Barking...");
        }
    }
    class Q101
    {
        static void Main(string[] args)
        {
            Dog d = new Dog();
            d.eat();
            d.bark();
            Console.ReadKey();
        }
    }
}

/* 
    Eating...
    Barking... 
*/