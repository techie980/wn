
package com.exam;

/**
12. Write a Java program to demonstrate Inheritance (Use the super keyword). 
 */

class Employees {
    String name;
    double basicSalary;
    String department = "General Department";
    
    //Parent Constructor
    Employees(String name, double basicSalary){
        this.name = name;
        this.basicSalary = basicSalary;
    }
    
    void displayDetails(){
        System.out.println("Employee Name :- " + name);
        System.out.println("Employee Basic Salary :- " + basicSalary);
    }
}

class Manager extends Employees {
    double bonus;
    String department = "IT Department";
    
    // Child Constructor
    Manager(String name,double basicSalary,double bonus){
        super(name, basicSalary);
        this.bonus = bonus;
    }
    
    @Override
    public void displayDetails(){
        super.displayDetails();
        System.out.println("Bonus :- " + bonus);
        System.out.println("Total Salary :- " + (basicSalary + bonus));
        System.out.println("Parent Department :- " + super.department);
        System.out.println("Child Department :- " + this.department);
    }
}

public class Q12 {
    public static void main(String[] args) {
        
        Manager mgr = new Manager("Smith",10000,1000);
        mgr.displayDetails();
    }
}
