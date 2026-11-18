
package com.exam;

/**
Write a Java program to demonstrate an abstract class. 
*/
abstract class Shape {
    String color;
    
    Shape(String color){
        this.color = color;
    }
    
    abstract double calculateArea();
    
    void displayColor(){
        System.out.println("Shape Color :- " + color);
    }
}

class Circle extends Shape{
    
    double radius;
    
    Circle(String color, double radius){
        super(color);
        this.radius = radius;
    }
    
    @Override
    double calculateArea(){
        return Math.PI * radius * radius;
    }
}

class Rectangle extends Shape{
    
    double length;
    double width;
    
    Rectangle(String color, double length, double width){
        super(color);
        this.length = length;
        this.width = width;
    }
    
    @Override
    double calculateArea(){
        return length * width;
    }
}

public class Q14 {
    public static void main(String[] args) {
        
        Shape s1 = new Circle("Red", 12.5);
        s1.displayColor();
        System.out.println("Circle Area :- " + s1.calculateArea());
        
        Shape s2 = new Rectangle("Green", 10, 10);
        s2.displayColor();
        System.out.println("Rectangle Area :- " + s2.calculateArea());
    }
}
