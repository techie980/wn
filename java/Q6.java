
package com.exam;

/**
 Write a Java program to demonstrate constructors and constructor overloading.
 */

class Students {
    int rollNo;
    String name;
    double marks;
    
    //No args
    Students(){
        rollNo = 0;
        name = "Unknown";
        marks = 0.0;
    }
    
    // 2 args
    Students(int rollNo, String name){
        this.rollNo = rollNo;
        this.name = name;
        this.marks = 0.0;
    }
     
    // 3 args
    Students(int rollNo, String name, double marks){
        this.rollNo = rollNo;
        this.name = name;
        this.marks = marks;
    }
    
    void display(){
        System.out.println("Roll Number :- " + rollNo);
        System.out.println("Name :- " + name);
        System.out.println("Marks :- " + marks);

    }
}

public class Q6 {
    public static void main(String[] args) {
        Students s1 = new Students();
        s1.display();
        
        Students s2 = new Students(101, "Saurabh");
        s2.display();
        
        Students s3 = new Students(102, "Shubham", 95.33);
        s3.display();
    }
}
