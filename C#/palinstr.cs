using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ass
{
    class Q26
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a string: ");
            string str = Console.ReadLine();
            string rev = string.Empty;
            for (int i = str.Length - 1; i >= 0; i--)
            {
                rev += str[i];
            }

            if (str == rev)
            {
                Console.WriteLine(str + " is Palindrome");
            }
            else
            {
                Console.WriteLine(str + " is Not Palindrome");

            }
            Console.ReadKey();
        }
    }
}

/*
    Enter a string: madam
    madam is Palindrome 
*/