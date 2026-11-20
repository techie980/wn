using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ass
{
    class student
    {
        public int marks;
        public student(int m)
        {
            marks = m;
        }
        public static student operator +(student s1, student s2)
        {
            return new student(s1.marks + s2.marks);
        }
    }
    class Q123
    {
        static void Main(string[] args) 
        {
            student s1 = new student(40);
            student s2 = new student(50);
            student s3 = s1 + s2;
            Console.WriteLine("Total Marks: " + s3.marks);
            Console.ReadKey();
        }
    }
}

/* Total Marks: 90 */