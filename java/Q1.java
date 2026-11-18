
package com.exam;

import java.util.Scanner;

/**
Write a Java program to check whether a given number is odd or even. If the number is odd, 
check whether it is a multiple of 5. If the number is even, check whether it is a multiple of 4.
 */
public class Q1 {

    public static void main(String[] args) {

        Scanner scan = new Scanner(System.in);
        int num;
        
        System.out.print("Enter a Number :- ");
        num = scan.nextInt();
        
        if(num%2 != 0){
            
            System.out.println(num + " is Odd");
            
            if(num % 5 == 0){
                System.out.println(num + " is Multiple of 5");
            }
            else{
                System.out.println(num + " is Not a Multiple of 5");
            }
        }
        else{
            System.out.println(num + " is even");
            
            if(num % 4 == 0){
                System.out.println(num + " is Multiple of 4");
            }
            else{
                System.out.println(num + " is Not a Multiple of 4");
            }
        }
        
        scan.close();
    }
}
