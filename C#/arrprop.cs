using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ass
{
    class Q44
    {
        static void Main(string[] args)
        {
            int[] a = new int[7];
            Console.WriteLine("Array is of Fixed Size : " + a.IsFixedSize);
            Console.WriteLine("Array is of Read Only : " + a.IsReadOnly);
            Console.WriteLine("Array Length is : " + a.Length);
            Console.WriteLine("Array long Length is : " + a.LongLength);
            Console.WriteLine("Array  Rank is : " + a.Rank);

            Console.ReadKey();
        }
    }
}

/* 
    Array is of Fixed Size : True
    Array is of Read Only : False
    Array Length is : 7
    Array long Length is : 7
    Array  Rank is : 1
*/