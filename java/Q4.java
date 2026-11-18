
package com.exam;

/**
 *
Write a Java program to define a class, objects, a field and a method.
*/

class Student {

    int rollNo;
    String name;
    
    public void display(){
        System.out.println("Roll No. :- " + rollNo);
        System.out.println("Name :- " + name);
    }
}

public class Q4 {
    public static void main(String[] args) {
        
        Student s1 = new Student();
        
        s1.rollNo = 101;
        s1.name = "Saurabh";
        
        s1.display();
        
        Student s2 = new Student();
        
        s2.rollNo = 102;
        s2.name = "Shubham";
        
        s2.display();
    }
}
