using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ass
{
    class Q11
    {
        static void Main(string[] args)
        {
            int num;
            Console.Write("Enter any number: ");
            num = Convert.ToInt32(Console.ReadLine());
            if (num > 0)
            {
                Console.WriteLine("{0} number is positive", num); 
            }
            else if (num < 0)
            {
                Console.WriteLine("{0} number is negative", num);
            }
            else 
            {
                Console.WriteLine("{0} number is Zero", num);
            }
            Console.ReadKey();
        }
    }
}
/*Enter any number: 5
5 number is positive*/