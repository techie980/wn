using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ass
{
    class Q42
    {
        static void Main(string[] args)
        {
            int i, j, row, col;
            Console.WriteLine("Enter the size of the row: ");
            row = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the size the column: ");
            col = int.Parse(Console.ReadLine());
            int[,] x = new int[row, col];
            int[,] y = new int[row, col];
            int[,] z = new int[row, col];

            // First Matrix
            Console.WriteLine("Enter the elements to first matrix: ");
            for (i = 0; i < row; i++)
            {
                Console.Write("");
                for (j = 0; j < col; j++)
                {
                    x[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.WriteLine("The first matrix elements are: ");
            for (i = 0; i < row; i++)
            {
                Console.WriteLine("\n");
                for (j = 0; j < col; j++)
                {
                    Console.Write("{0}\t", x[i, j]);
                }
            }

            // Second Matrix
            Console.WriteLine("\nEnter the elements to second matrix: ");
            for (i = 0; i < row; i++)
            {
                Console.Write("");
                for (j = 0; j < col; j++)
                {
                    y[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.WriteLine("The second matrix elements are: ");
            for (i = 0; i < row; i++)
            {
                Console.WriteLine("\n");
                for (j = 0; j < col; j++)
                {
                    Console.Write("{0}\t", y[i, j]);
                }
            }
            for (i = 0; i < row; i++)
            {
                for (j = 0; j < col; j++)
                {
                    z[i, j] = x[i, j] + y[i, j];
                }
            }
            Console.WriteLine("\nThe Sum of Matrix is");
            for (i = 0; i < row; i++)
            {
                Console.WriteLine("\n");
                for (j = 0; j < col; j++)
                {
                    Console.Write("{0}\t", z[i, j]);
                }
            }
            for (i = 0; i < row; i++)
            {
                for (j = 0; j < col; j++)
                {
                    z[i, j] = x[i, j] - y[i, j];
                }
            }

            Console.WriteLine("\nThe Subtraction of Matrix is");
            for (i = 0; i < row; i++)
            {
                Console.WriteLine("\n");
                for (j = 0; j < col; j++)
                {
                    Console.Write("{0}\t", z[i, j]);
                }
            }
            for (i = 0; i < row; i++)
            {
                for (j = 0; j < col; j++)
                {
                    z[i, j] = 0;
                    for (int k = 0; k < 2; k++)
                    { 
                        z[i, j] += x[i, j] * y[k, j];
                    }
                }
            }


            Console.WriteLine("\nThe Multiplication of Matrix is");
            for (i = 0; i < row; i++)
            {
                Console.WriteLine("\n");
                for (j = 0; j < col; j++)
                {
                    Console.Write("{0}\t", z[i, j]);
                }
            }
            Console.ReadKey();
        }
    }
}

/* 
    The first matrix elements are:


    1       2

    3       4
    Enter the elements to second matrix:
    5
    6
    7
    8
    The second matrix elements are:


    5       6

    7       8
    The Sum of Matrix is


    6       8

    10      12
    The Subtraction of Matrix is


    -4      -4

    -4      -4
    The Multiplication of Matrix is


    12      28

    36      56 
*/