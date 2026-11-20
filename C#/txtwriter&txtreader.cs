using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Ass
{
    class Q165
    {
        static void Main(string[] args) 
        {
            string fp;
            Console.WriteLine("Enter File Path: ");
            fp = Console.ReadLine();
            using (TextWriter tw = File.CreateText(fp))
            {
                tw.WriteLine("Have a Good Day");
                tw.WriteLine("Silence Please");
            }
            Console.WriteLine("File Written Successfully");
            Console.WriteLine("Data from File is");
            using (TextReader tr = File.OpenText(fp))
            {
                Console.WriteLine(tr.ReadToEnd());
            }
            Console.ReadKey();
        }
    }
}

/* 
    Enter File Path:
    C:\Jay (C#)\a.txt
    File Written Successfully
    Data from File is
    Have a Good Day
    Silence Please 
*/