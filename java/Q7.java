
package com.exam;

import java.util.Scanner;

/**
Write a Java program to define an array of Strings and display the array elements. 
 */
public class Q7 {
    public static void main(String[] args) {
        
        Scanner scan = new Scanner(System.in);
        
        System.out.print("Enter Number of Strings :- ");
        int n = scan.nextInt();
        scan.nextLine();
        String[] names = new String[n];
        
        for(int i = 0;i < n;i++){
            System.out.print("Enter " + (i + 1) + " String :- ");
            names[i] = scan.nextLine();
        }
        
        System.out.println("Array Elements :-");
        for(int i=0;i<names.length;i++){
            System.out.println(names[i]);
        }
    }
}
