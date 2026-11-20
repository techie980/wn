using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ass
{
    public delegate string SayDelegate(string st);
    public delegate void AddDelegate(int a, int b);
    
    class Q93
    {
        public static string Say(string str) 
        {
            return str;
        }
        public void Add(int a, int b) 
        {
            Console.WriteLine(a + b);
        }
        static void Main(string[] args)
        {
            Q93 q = new Q93();
            SayDelegate sd = new SayDelegate(Say);
            Console.WriteLine(sd("Hello"));
            AddDelegate ad = new AddDelegate(q.Add);
            ad(1, 2);
            Console.ReadKey();
        }
    }
}

/* 
    Hello
    3 
*/
