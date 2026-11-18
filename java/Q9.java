
package com.exam;

import java.util.Scanner;

/**
Aim: Write a Java program to create and display a jagged array using a for-each loop.
 */
public class Q9 {
    public static void main(String[] args) {
        
//        int[][] arr = {
//            {10, 20},
//            {30, 40, 50},
//            {60, 70, 80, 90}
//        };

        Scanner scan = new Scanner(System.in);
        int rows;
        
        System.out.println("Enter number of rows :- ");
        rows = scan.nextInt();
        int[][] arr = new int[rows][];

        
        for(int i = 0;i < rows;i++){
            System.out.print("Enter number of columns for row " + (i + 1) + ": ");
            int cols = scan.nextInt();
            
            arr[i] = new int[cols];
            for(int j = 0;j < cols;j++){
                System.out.print("Enter Elements :- ");
                arr[i][j] = scan.nextInt();
            }
        }
 
        System.out.println("Jagged Array Elements :- ");
        
        // for-each
        for(int[] row : arr){
            for(int n : row){
                System.out.print(n + " ");
            }
            System.out.println();
        }
        
//        Normal Printing
//        for(int i = 0;i < arr.length;i++){
//           for(int j = 0;j < arr[i].length;j++){
//               System.out.print(arr[i][j] + " ");
//           }
//            System.out.println("");
//        }

    }
}
