
package com.exam;

import java.util.Scanner;

/**
 2. Write a program to display the sum of the digits of a given number.
 */
public class Q2 {
    public static void main(String[] args) {
        
        Scanner scan = new Scanner(System.in);
        int num;
        int sum = 0;
                
        System.out.print("Enter a Number :- ");
        num = scan.nextInt();
        
        int temp = Math.abs(num);
        
        while(temp > 0){
            sum += temp%10;
            temp /= 10;
        }
        
        System.out.println("Sum of digits of " + num + " = " + sum);

        scan.close();
    }
}
