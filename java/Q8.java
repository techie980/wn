
package com.exam;

import java.util.Scanner;

/**
Write a Java program to find the count of duplicate numbers in an array.
 */
public class Q8 {
    public static void main(String[] args) {
        
        Scanner scan = new Scanner(System.in);
        
        System.out.print("Enter Number of Elements :- ");
        int n = scan.nextInt();
        
        int[] arr = new int[n];
        
        for(int i = 0;i < n;i++){
            System.out.print("Enter " + (i + 1) + " Element :-");
            arr[i] = scan.nextInt();
        }
        
        int count = 0;
        
        for(int i = 0;i < arr.length;i++){
            
            boolean alreadyCounted = false;
            
            for(int k = 0;k < i;k++){
                if(arr[i] == arr[k]){
                    alreadyCounted = true;
                    break;
                }
            }
            
            if(!alreadyCounted){
                
                int frequency = 0;
                
                for(int j = 0;j < arr.length;j++){
                    if(arr[i] == arr[j]){
                        frequency++;
                    }
                }
                
                if(frequency > 1){
                    count++;
                    System.out.println(arr[i] + " occurs " + frequency + " times");
                }
            }
        }
        
        System.out.println("Total Duplicate Numbers :- " + count);
    }
}
