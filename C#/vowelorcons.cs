using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ass
{
    class Q14
    {
        static void Main(string[] args)
        {
            char ch;
            Console.Write("Input alphabet (A-Z or a-z): ");
            ch = Convert.ToChar(Console.ReadLine().ToLower());
            int i = ch;
            if (i >= 48 && i <= 57)
            {
                Console.WriteLine("Number not allowed");
            }
            else
            {
                switch (ch)
                { 
                    case 'a':
                        Console.WriteLine("Vowel");
                        break;
                    case 'e':
                        Console.WriteLine("Vowel");
                        break;
                    case 'i':
                        Console.WriteLine("Vowel");
                        break;
                    case 'o':
                        Console.WriteLine("Vowel");
                        break;
                    case 'u':
                        Console.WriteLine("Vowel");
                        break;
                    default:
                        Console.WriteLine("Consonant");
                        break;
                }
            }
            Console.ReadKey();
        }
    }
}

/*
    Input alphabet (A-Z or a-z): e
    Vowel 
*/
