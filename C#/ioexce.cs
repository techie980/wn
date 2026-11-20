using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Ass
{
    class Q141
    {
        static void Main(string[] args)
        {
            try
            {
                File.Open("C:/ex.txt", FileMode.Open);
                Console.WriteLine("File not found");
            }
            catch(IOException ex)
            {
                Console.WriteLine(ex.ToString());
            }
            Console.ReadKey();
        }
    }
}
/* 
    System.IO.FileNotFoundException: Could not find file 'C:\ex.txt'.
    File name: 'C:\ex.txt'
       at System.IO.__Error.WinIOError(Int32 errorCode, String maybeFullPath)
       at System.IO.FileStream.Init(String path, FileMode mode, FileAccess access, Int32 rights, Boolean useRights, FileShare share, Int32 bufferSize, FileOptions options, SECURITY_ATTRIBUTES secAttrs, String msgPath, Boolean bFromProxy, Boolean useLongPath, Boolean checkHost)
       at System.IO.FileStream..ctor(String path, FileMode mode, FileAccess access, FileShare share)
       at System.IO.File.Open(String path, FileMode mode)
       at Ass.Q141.Main(String[] args) in c:\Jay (C#)\Ass\Ass\Q141.cs:line 16 
*/