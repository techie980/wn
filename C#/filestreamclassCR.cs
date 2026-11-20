using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Ass
{
    class Q161
    {
        static void Main(string[] args) 
        {
            string fname, data;
            Console.WriteLine("Enter file name");
            fname = Console.ReadLine();
            FileStream fa = new FileStream(fname, FileMode.Append);
            Console.WriteLine("Enter the data to appending to the " + fname + " file: ");
            data = Console.ReadLine();
            byte[] bdata = Encoding.Default.GetBytes(data);
            fa.Write(bdata, 0, bdata.Length);
            fa.Close();
            Console.WriteLine("File saved successfully");
            Console.ReadLine();
        }
    }
}

/*
    Enter file name
    C:\Jay (C#)/a.txt
    Enter the data to appending to the C:\Jay (C#)/a.txt file:
    Good Morning Friends
    File saved successfully 
*/