using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ass
{
    class Q43
    {
        static void Main(string[] args) 
        {
            Console.WriteLine("Single dimensional jagged array: ");
            int[][] a = 
            {
                new int []{1,5,7,9},
                new int []{10,25,99},
                new int []{15,2},
                new int []{1,10,5,0,50}
            };

            for (int i = 0; i < a.Length; i++)
            {
                for (int j = 0; j < a[i].Length; j++)
                {
                    Console.Write(a[i][j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine("Multi Dimensional jagged Array: ");
            int[][,] b = new int[][,]
            {
                new int[,]{{2,4}, {1,5}},
                new int[,]{{10,20}, {15,34}, {19,13}},
                new int[,]{{11,80}, {82,98}, {11, 66}},
                new int[,]{{45,73}, {71,54}, {5,19}}
            };

            for (int i = 0; i < b.Length; i++)
            {
                int x = 0;
                for (int j = 0; j < b[i].GetLength(0); j++)
                {
                    for (int k = 0; k < b[j].Rank; k++)
                    {
                        Console.Write("Jagged Array [" + i + "][" + j + "," + k + "]:" + b[i][j,k] + " ");

                    }
                    Console.WriteLine();
                }
                x++;
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}

/* 
    Single dimensional jagged array:
    1 5 7 9
    10 25 99
    15 2
    1 10 5 0 50

    Multi Dimensional jagged Array:
    Jagged Array [0][0,0]:2 Jagged Array [0][0,1]:4
    Jagged Array [0][1,0]:1 Jagged Array [0][1,1]:5

    Jagged Array [1][0,0]:10 Jagged Array [1][0,1]:20
    Jagged Array [1][1,0]:15 Jagged Array [1][1,1]:34
    Jagged Array [1][2,0]:19 Jagged Array [1][2,1]:13

    Jagged Array [2][0,0]:11 Jagged Array [2][0,1]:80
    Jagged Array [2][1,0]:82 Jagged Array [2][1,1]:98
    Jagged Array [2][2,0]:11 Jagged Array [2][2,1]:66

    Jagged Array [3][0,0]:45 Jagged Array [3][0,1]:73
    Jagged Array [3][1,0]:71 Jagged Array [3][1,1]:54
    Jagged Array [3][2,0]:5 Jagged Array [3][2,1]:19
*/