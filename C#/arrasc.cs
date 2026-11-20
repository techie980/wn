using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ass
{
    class Q41
    {
        public static void Sort(int[] a)
        {
            int k, j, temp;
            Console.WriteLine("Array elements in ascending order: ");
            for (k = 0; k < a.Length - 1; k++)
            {
                for (j = 0; j < a.Length - 1; j++)
                { 
                    if (a[j] > a[j + 1])
                    {
                        temp = a[j];
                        a[j] = a[j + 1];
                        a[j + 1] = temp;
                    }
                }
            }
            for (k = 0; k < a.Length; k++)
            {
                Console.WriteLine(a[k]);
            }
        }
        
        static void Main(string[] args) 
        { 
           int[] a = {61, 58, 17, 7, 16, 6, 9};
           Sort(a);
           Console.ReadKey();
        }
        
    }
}

/* 
    Array elements in ascending order:
    6
    7
    9
    16
    17
    58
    61
*/