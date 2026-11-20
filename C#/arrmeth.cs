using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ass
{
    class Q45
    {
        static void PrintArray(int[] a) 
        {
            foreach(object o in a)
            {
                Console.Write(o + " ");
            }
        }

        static void Main(string[] args) 
        {
            int[] a = new int[6] { 7, 6, 2, 9, 5, 4 };
            int[] b = new int[6];
            Console.WriteLine("Length of First array: " + a.Length);
            Array.Sort(a);
            Console.WriteLine("First Array Elements : ");
            PrintArray(a);
            Console.WriteLine("\nIndex Position of 9 is : " + Array.IndexOf(a, 9));
            Array.Copy(a, b, b.Length);

            Console.WriteLine("Second Array Elements : ");
            PrintArray(b);
            Array.Reverse(a);
            Console.WriteLine("\nFirst array Elements in reverse order: ");
            PrintArray(a);
            Console.ReadKey();
        }
    }
}

/* 
    Length of First array: 6
    First Array Elements :
    2 4 5 6 7 9
    Index Position of 9 is : 5
    Second Array Elements :
    2 4 5 6 7 9
    First array Elements in reverse order:
    9 7 6 5 4 2
*/