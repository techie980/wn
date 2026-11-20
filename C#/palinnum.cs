using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ass
{
    class Q25
    {
        static void Main(string[] args)
        {
            int r, sum = 0, temp;
            Console.Write("Enter the number: ");
            int n = int.Parse(Console.ReadLine());
            temp = n;
            while (n > 0)
            {
                r = n % 10;
                sum = (sum * 10) + r;
                n = n / 10;
            }
            if (temp == sum)
            {
                Console.WriteLine("Number " + temp + " is Palindrome");
            }
            else
            {
                Console.WriteLine("Number " + temp + " is Not Palindrome");

            }
            Console.ReadKey();
        }
    }
}

/* 
    Enter the number: 121
    Number 121 is Palindrome 
*/
