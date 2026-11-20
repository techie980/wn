using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ass
{
    class Q32
    {
        static void Main(string[] args) 
        {
            int rollno;
            string name, cls;
            rollno = Convert.ToInt32(args[0]);
            name = args[1];
            cls = args[2];
            Console.WriteLine("Your RollNo is " + rollno);
            Console.WriteLine("Your Name is " + name);
            Console.WriteLine("Your Class is " + cls);
            Console.ReadKey();
        }
    }
}

/* 
    C:\Jay (C#)\Ass\Ass>csc Q32.cs
    Microsoft (R) Visual C# Compiler version 4.8.9232.0
    for C# 5
    Copyright (C) Microsoft Corporation. All rights reserved.

    This compiler is provided as part of the Microsoft (R) .NET Framework, but only supports language versions up to C# 5,
     which is no longer the latest version. For compilers that support newer versions of the C# programming language, 
     see http://go.microsoft.com/fwlink/?LinkID=533240


    C:\Jay (C#)\Ass\Ass>Q32 08 Jay BCS-III
    Your RollNo is 8
    Your Name is Jay
    Your Class is BCS-III
*/