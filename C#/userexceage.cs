using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ass
{
    public class InvalidAgeException : Exception 
    {
        public InvalidAgeException(string message)
           : base(message)
        {
        }
    }
    class Q151
    {
        static void validate(int age) 
        {
            if (age < 18)
            {
                throw new InvalidAgeException("Sorry, Age must be greater than 18");
            }
            else 
            {
                Console.WriteLine("Congratulations, Age is greater than 18");
            }
        }
        static void Main(string[] args) 
        {
            try 
            {
                validate(12);
            }
            catch(InvalidAgeException e)
            {
                Console.WriteLine(e);
            }
            Console.ReadKey();
        }
    }
}
/* 
    Ass.InvalidAgeException: Sorry, Age must be greater than 18
    at Ass.Q151.validate(Int32 age) in c:\Jay (C#)\Ass\Ass\Q151.cs:line 22
    at Ass.Q151.Main(String[] args) in c:\Jay (C#)\Ass\Ass\Q151.cs:line 33 
*/