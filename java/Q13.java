
package com.exam;

import package1.BaseClass;
/**
13. Write a Java program to demonstrate a user-defined package and the use of access specifiers.
 */

class SubClass extends BaseClass {
    void displayInSubClass(){
        System.out.println("\n--- Inside Subclass in Different Package (com.exam.SubClass) ---");
        System.out.println("Public Var :- " + pubVar);
        System.out.println("Protected Var :- " + protVar);
//      System.out.println("Private Var :- " + priVar);
//      System.out.println("Default Var :- " + defVar);
    }
}

public class Q13 {
    public static void main(String[] args) {
        BaseClass baseClass = new BaseClass();
        baseClass.displayInsideSameClass();
        
        SubClass subClass  = new SubClass();
        subClass.displayInSubClass();
        
        System.out.println("\n--- Inside Non-Subclass in Different Package (com.exam.Q13) ---");
        System.out.println("Public Var :- " + baseClass.pubVar);
//      System.out.println("Protected Var :- " + protVar);
//      System.out.println("Private Var :- " + priVar);
//      System.out.println("Default Var :- " + defVar);
    }
}
