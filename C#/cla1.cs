using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ass
{
    class Q31
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Argument Length: " + args.Length);
            Console.WriteLine("Supplied arguments");
            foreach (Object obj in args) 
            {
                Console.WriteLine(obj);
            }
            Console.ReadKey();
        }
    }
}

/* 
    C:\Program Files (x86)\Microsoft Visual Studio 11.0>cd C:\Jay (C#)\Ass\Ass

    C:\Jay (C#)\Ass\Ass>csc Q31.cs
    Microsoft (R) Visual C# Compiler version 4.8.9232.0
    for C# 5
    Copyright (C) Microsoft Corporation. All rights reserved.

    This compiler is provided as part of the Microsoft (R) .NET Framework, but only supports language versions up to C# 5, 
    which is no longer the latest version. For compilers that support newer versions of the C# programming language, 
    see http://go.microsoft.com/fwlink/?LinkID=533240

    C:\Jay (C#)\Ass\Ass>Q31 Welcome to Willingdon College Sangli
    Argument Length: 5
    Supplied arguments
    Welcome
    to
    Willingdon
    College
    Sangli 
*/