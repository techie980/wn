
package com.exam;

/**
 Write a Java program to demonstrate method overloading.
 */

class Calculator{
 
    int add(int a, int b){
        return a + b;
    }
     
    int add(int a, int b,int c){
        return a + b + c;
    }
    
    float add(float a, float b){
        return a + b;
    }
}

public class Q5 {
    
    public static void main(String[] args) {
        
        Calculator calc = new Calculator();
        
        System.out.println("Sum of Two Integers :- " + calc.add(10,20));
        System.out.println("Sum of Three Integers :- " + calc.add(10,20,30));
        System.out.println("Sum of Two floating Numbers :- " + calc.add(10.5f,20.5f));

    }
}
