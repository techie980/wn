using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ass;

namespace Ass
{
    class Q131
    {
        static void Main(string[] args)
        {
            MyMath m = new MyMath();
            Console.WriteLine("Addition: " + m.Add(10, 12));
            Console.WriteLine("Substraction: " + m.Subtract(100, 12));
            Console.WriteLine("Multiplication: " + m.Multiplication(10, 11));
            Console.WriteLine("Division: " + m.Division(100, 12));

            Console.ReadKey();
        }
    }
}
/* 
    Addition: 22
    Substraction: 88
    Multiplication: 110
    Division: 8.33333333333333 
*/
