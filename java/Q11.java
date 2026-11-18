
package com.exam;

import java.util.ArrayList;
import java.util.Iterator;
import java.util.Scanner;

/**
11. Write a Java program to create an ArrayList of Integers and display the elements of the ArrayList.
 */
public class Q11 {
    public static void main(String[] args) {
        
        Scanner scan = new Scanner(System.in);
        
        ArrayList<Integer> list = new ArrayList<>();
        
        System.out.print("Enter Number of Elements :- ");
        int n = scan.nextInt();
        
        for(int i = 0;i < n;i++){
            System.out.print("Enter " + (i + 1) + " integer :- ");
            list.add(scan.nextInt());
        }
        
        // Method 1: Direct printing (calls toString())
        System.out.println("Direct Display :- " + list );
        
        // Method 2: for-each
        System.out.print("2. Using For-Each Loop :- ");
        for(int num : list){
            System.out.print(num + " ");
        }
        
        // Method 3: Using Iterator
        System.out.print("\n3. Using Iterator :- ");
        
        Iterator<Integer> itr = list.iterator();
        while(itr.hasNext()){
            System.out.print(itr.next() + " ");
        }
        
        scan.close();
    }
}

//// 1. ADD (Create)
//        System.out.print("Enter number of elements :- ");
//        int n = scan.nextInt();
//
//        for (int i = 0; i < n; i++) {
//            System.out.print("Enter integer " + (i + 1) + " :- ");
//            list.add(scan.nextInt()); // Appends at the end
//        }
//        System.out.println("\nInitial List :- " + list);
//
//        // Add at a specific index: list.add(index, element)
//        list.add(0, 99);
//        System.out.println("After adding 99 at index 0 :- " + list);
//
//        // 2. UPDATE: list.set(index, newElement)
//        if (list.size() > 1) {
//            list.set(1, 555); // Replaces element at index 1 with 555
//            System.out.println("After updating index 1 to 555 :- " + list);
//        }
//
//        // 3. REMOVE (Delete)
//        // A) Remove by Index
//        if (!list.isEmpty()) {
//            int removedByIdx = list.remove(0); // Removes element at index 0
//            System.out.println("Removed element at index 0 (" + removedByIdx + ") :- " + list);
//        }
//
//        // B) Remove by Value (Must use Integer.valueOf() for ArrayList<Integer>)
//        System.out.print("\nEnter a value to remove from list :- ");
//        int valToRemove = scan.nextInt();
//        boolean isRemoved = list.remove(Integer.valueOf(valToRemove));
//        if (isRemoved) {
//            System.out.println("After removing value " + valToRemove + " :- " + list);
//        } else {
//            System.out.println("Value " + valToRemove + " not found in list.");
//        }
//
//        // 4. SEARCH & READ
//        System.out.println("\nTotal Elements (size) :- " + list.size());
//        if (!list.isEmpty()) {
//            System.out.println("First Element (get) :- " + list.get(0));
//            System.out.println("Contains 555? :- " + list.contains(555));
//        }
//
//        // 5. SORT (Bonus utility)
//        Collections.sort(list);
//        System.out.println("Sorted List :- " + list);