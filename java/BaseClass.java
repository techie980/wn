
package package1;

public class BaseClass {
    public int pubVar = 10;
    private int priVar = 20;
    protected int protVar = 30;
    int defVar = 40;
    
    public void displayInsideSameClass(){
        System.out.println("----Inside Same Class(pckage 1)----");
        System.out.println("Public Variable :- " + pubVar);
        System.out.println("Private Variable :- " + priVar);
        System.out.println("Protected Variable :- " + protVar);
        System.out.println("Default Variable :- " + defVar);
    }
}
