using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Ass
{
    class Q162
    {
        static void Main(string[] args) 
        {
            string fname, data;
            Console.WriteLine("Enter file name");
            fname = Console.ReadLine();
            FileStream fa = new FileStream(fname, FileMode.Open, FileAccess.Read, FileShare.None);
            StreamReader sr = new StreamReader(fa);
            data = sr.ReadToEnd();
            Console.WriteLine(data);
            Console.ReadKey();
        }
    }
}

/* 
    Enter file name
    C:\Jay (C#)\a.txt
    Good Morning Friends
*/