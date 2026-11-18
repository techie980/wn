
package com.exam;

import static java.lang.Thread.sleep;

/**
17. Write a Java program to demonstrate multithreading (e.g., create and run multiple threads using 
 different thread life cycle methods)
 */

// Way-1 Extending the thread class
class NumberThread extends Thread {
    
    @Override
    public void run(){
        for(int i = 1;i <= 5;i++){
            System.out.println(getName() + " running - step " + i);
            try{
                sleep(500);
            }
            catch(InterruptedException ex){
                System.out.println(getName() + " Interrupted");
            }
        }
    }
}

// Way-2 Inplementing the Runnable Ineterface
class MessageThread implements Runnable {
    
    @Override
    public void run(){
        for(int i = 1;i <= 5;i++){
            System.out.println(Thread.currentThread().getName()+ " running - step " + i);
            try{
                sleep(500);
            }
            catch(InterruptedException ex){
                System.out.println("MessageTask Interrupted");
            }
        }
    }
}
public class Q17 {
    public static void main(String[] args) {
        
        NumberThread t1 = new NumberThread();
        t1.setName("NumberThread");
        
        MessageThread msg = new MessageThread();
        Thread t2 = new Thread(msg, "MessageThread");
        
        System.out.println("Starting both Threads Simultaneously..");
        t1.start();
        t2.start();
        
        try{
            t1.join();
            t2.join();
        }
        catch(InterruptedException ex){
            System.out.println("Main thread interrupted.");
        }
        
        System.out.println("\nBoth threads finished. Main thread exiting.");
    }
}
