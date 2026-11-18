
package com.exam;

import java.util.Scanner;

/**
16. Write a Java program to demonstrate user defined exception.
 */
class InvalidAgeException extends Exception {
    
    InvalidAgeException(String message){
       super(message);
    }
}

public class Q16 {
    
    static void checkVotingEligibility(int age)throws InvalidAgeException{
        
        if(age < 18){
            throw new InvalidAgeException("Age " + age + " is Invalid. Must be 18 or older to vote");
        }
        else{
            System.out.println("Eligible to vote");
        }
    }
    
    public static void main(String[] args) {
        
        Scanner scan = new Scanner(System.in);
        
        System.out.print("Enter your age :- ");
        int age = scan.nextInt();
        
        try{
            checkVotingEligibility(age);
        }
        catch(InvalidAgeException ex){
            System.out.println("Caught an Custom Exception : " + ex.getMessage());
        }
        finally{
            System.out.println("Verification process completed.");
            scan.close();
        }
    }
}

//package com.exam;
//
//import java.util.Scanner;
//
//public class BuiltInExceptionDemo {
//    public static void main(String[] args) {
//        Scanner scan = new Scanner(System.in);
//
//        try {
//            // 1. ArithmeticException (Division by zero)
//            System.out.print("Enter numerator :- ");
//            int a = scan.nextInt();
//            System.out.print("Enter denominator :- ");
//            int b = scan.nextInt();
//            System.out.println("Result :- " + (a / b));
//
//            // 2. ArrayIndexOutOfBoundsException (Invalid array index)
//            int[] arr = {10, 20, 30};
//            System.out.print("Enter array index (0-2) :- ");
//            int idx = scan.nextInt();
//            System.out.println("Element :- " + arr[idx]);
//
//        } catch (ArithmeticException e) {
//            System.out.println("Built-in Exception Caught :- Cannot divide by zero!");
//        } catch (ArrayIndexOutOfBoundsException e) {
//            System.out.println("Built-in Exception Caught :- Array index out of range!");
//        } catch (Exception e) {
//            // General fallback (e.g., InputMismatchException if user enters text)
//            System.out.println("Built-in Exception Caught :- " + e);
//        } finally {
//            System.out.println("Execution finished safely.");
//            scan.close();
//        }
//    }
//}