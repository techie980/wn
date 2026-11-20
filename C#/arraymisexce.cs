using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ass
{
    class Q143
    {
        static void Main(string[] args)
        {
            string[] arr1 = {"Hello", "World"};
            int[] arr2 = {1, 2};
            try
            {
                Array.Copy(arr1, arr2, 2);
            }
            catch (ArrayTypeMismatchException ex)
            {
                Console.WriteLine(ex.ToString());
            }
            Console.ReadKey();
        }
    }
}

/* 
    System.ArrayTypeMismatchException: Source array type cannot be assigned to destination array type.
   at System.Array.Copy(Array sourceArray, Int32 sourceIndex, Array destinationArray, Int32 destinationIndex, Int32 length, Boolean reliable)
   at System.Array.Copy(Array sourceArray, Array destinationArray, Int32 length)
   at Ass.Q143.Main(String[] args) in c:\Jay (C#)\Ass\Ass\Q143.cs:line 17 
*/