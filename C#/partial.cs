using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ass
{
    public partial class user 
    {
        private string name, location;

        public user(string a, string b) 
        {
            this.name = a;
            this.location = b;
        }
    }

    public partial class user
    {
        public void GetUserDetails()
        {
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Location: " + location);
        }
    }
    class Q81
    {
        static void Main(string[] args)
        {
            user u = new user("Jay", "Sangli");
            u.GetUserDetails();
            Console.ReadKey();
        }
    }
}
/*
   Name: Jay
    Location: Sangli
*/