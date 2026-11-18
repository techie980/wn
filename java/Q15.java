
package com.exam;

/**
15. Write a Java program to demonstrate multiple inheritance using an interface.
 */
interface Printable {
    String FORMAT = "PDF";
    void print();
}

interface Scannable {
    void scan();
}

class SmartPrinter implements Printable, Scannable {
    
    String documentName;
    
    SmartPrinter(String documentName){
        this.documentName = documentName;
    }
    
    @Override
    public void print(){
        System.out.println("Printing '" + documentName + "' in " + FORMAT + " format.");
    }
    
    @Override
    public void scan(){
        System.out.println("Scanning '" + documentName + "' in " + FORMAT + " format.");
    }
}

public class Q15 {
    public static void main(String[] args) {
        
        SmartPrinter printer = new SmartPrinter("JavaAssignment.pdf");
        printer.print();
        printer.scan();
    }
}
