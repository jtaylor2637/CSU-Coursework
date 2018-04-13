
/**
 * feedable interface
 * 
 * @author Radhouane 
 * @version 9/16/2014
 */
public interface Feedable
{
    //Interface must be cohesive
    //all of the methods must be actions that 
    //relate directly to the interface's name
    //abstract method definition
      void feed (int amount);
      void doSomethingWhenFed();
}
