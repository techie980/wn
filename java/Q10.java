
package com.exam;

import java.util.Scanner;

/**
Write a Java program to create an array of objects and display their details.
 */

class Employee {
    int id;
    String name;
    double salary;
    
    void display(){
        System.out.println("Employee Id :- " + id);
        System.out.println("Employee Name :- " + name);
        System.out.println("Employee Salary :- " + salary);

    }
}

public class Q10 {
    public static void main(String[] args) {
        
        Scanner scan = new Scanner(System.in);
        
        System.out.print("Enter Number of Employee :- ");
        int n = scan.nextInt();
        
        Employee[] employees = new Employee[n];
        
        for(int i =0;i < n;i++){
            employees[i] = new Employee();
            
            System.out.println("\nEnter Details for Employee " + (i + 1));
            
            System.out.print("Enter Employee Id :- ");
            employees[i].id = scan.nextInt();
            
            System.out.print("Enter Employee Name :- ");
            employees[i].name = scan.nextLine();
            
            System.out.print("Enter Employee Salary :- ");
            employees[i].salary = scan.nextDouble();
            
        }
        
        System.out.println("---------------------Employee Details---------------------");
        for(int i = 0;i < n;i++){
            System.out.println("\nEmployee " + (i+1) + " Details");
            employees[i].display();
        }
        
        scan.close();
    }
}

// Alternate Program 

//import java.util.Scanner;
//
//class Student {
//    int rollNo;
//    String name;
//
//    void accept(Scanner sc) {
//        System.out.print("Enter Roll Number: ");
//        rollNo = sc.nextInt();
//
//        System.out.print("Enter Name: ");
//        name = sc.next();
//    }
//
//    void display() {
//        System.out.println("Roll Number: " + rollNo);
//        System.out.println("Name: " + name);
//    }
//}
//
//public class Assignment10 {
//    public static void main(String[] args) {
//
//        Scanner sc = new Scanner(System.in);
//
//        System.out.print("Enter number of students: ");
//        int n = sc.nextInt();
//
//        Student[] students = new Student[n];
//
//        // Accept student details
//        for (int i = 0; i < n; i++) {
//            students[i] = new Student();
//            System.out.println("\nEnter details of Student " + (i + 1));
//            students[i].accept(sc);
//        }
//
//        // Display student details
//        System.out.println("\nStudent Details:");
//
//        for (int i = 0; i < n; i++) {
//            System.out.println("\nStudent " + (i + 1));
//            students[i].display();
//        }
//
//        sc.close();
//    }
//}
