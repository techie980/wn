using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Ass
{
    class Q164
    {
        static void WriteBinaryFile()
        {
            using (BinaryWriter bw = new BinaryWriter(File.Open("C:/Jay (C#)/a.txt", FileMode.Create)))
            {
                bw.Write(12.5);
                bw.Write("This is string data");
                bw.Write(false);
            }
        }

        static void ReadBinaryFile()
        {
            using (BinaryReader br = new BinaryReader(File.Open("C:/Jay (C#)/a.txt", FileMode.Open)))
            {
                Console.WriteLine("Double value: " + br.ReadDouble());
                Console.WriteLine("String value: " + br.ReadString());
                Console.WriteLine("Booleaqn value: " + br.ReadBoolean());
            }
        }

        static void Main(string[] args)
        {
            WriteBinaryFile();
            ReadBinaryFile();
            Console.ReadKey();
        }
    } 
}

/* 
    Double value: 12.5
    String value: This is string data
    Booleaqn value: False 
*/