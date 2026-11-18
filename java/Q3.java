
package com.exam;

import java.util.Scanner;

/**
 *
Write a Java program to validate character input, numerical input, mobile number input and email input.
*/

public class Q3 {
    
    public static boolean isCharacter(String input){
        return input.matches("[a-zA-Z]+");
    }
    
    public static boolean isNumeric(String input){
        return input.matches("-?\\d+(\\.\\d+)?");
    }
    
    public static boolean isMobile(String input){
        return input.matches("[6-9]\\d{9}");
    }
    
    public static boolean isEmail(String input){
        return input.matches("^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\\.[a-zA-Z]{2,}$");
    }
    
    public static void main(String[] args) {
        
//        java.util.regex.Pattern.matches(regex, input)
        Scanner scan  = new Scanner(System.in);

        //Character
        System.out.print("Enter a Character :- ");
        String str = scan.next();
        
        if(isCharacter(str)){
            System.out.println("Given input is Character.");
        }
        else{
            System.out.println("Given input is not Character.");
        }
        
        //Numeric
        System.out.print("\nEnter a Numeric Input :- ");
        String numeric = scan.next();
        
        if(isNumeric(numeric)){
            System.out.println("Given input is Numerical.");
        }
        else{
            System.out.println("Given input is not Numerical.");
        }
        
        //Mobile Number
        System.out.print("\nEnter a Mobile Number :- ");
        String mobileNo = scan.next();
        
        if(isMobile(mobileNo)){
            System.out.println("Given input is Mobile Number.");
        }
        else{
            System.out.println("Given input is not Mobile Number.");
        }
        
        // Email
        System.out.print("\nEnter a Email :- ");
        String email = scan.next();
        
        if(isEmail(email)){
            System.out.println("Given input is Email.");
        }
        else{
            System.out.println("Given input is not Email.");
        }
        
        scan.close();
    }
}
