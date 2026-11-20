using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Ass
{
    class Q163
    {
        static void Main(string[] args)
        {
            string fname;
            Console.WriteLine("Enter File name");
            fname = Console.ReadLine();
            StreamWriter sw = new StreamWriter(fname);
            Console.WriteLine("Enter text into file");
            string str = Console.ReadLine();
            sw.WriteLine(str);
            Console.WriteLine("File Saved Successfully");
            sw.Close();
            StreamReader sr = new StreamReader(fname);
            Console.WriteLine("Data from file is: ");
            string line = sr.ReadLine();
            Console.WriteLine(line);
            Console.ReadKey();
        }
    }
}

/* 
    Enter File name
    C:\Jay (C#)\a.txt
    Enter text into file
    Good Evening to all
    File Saved Successfully
    Data from file is:
    Good Evening to all 
*/