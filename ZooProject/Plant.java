import java.util.Random; 
public class Plant implements Feedable
{
   int length;
   String town;
   
   public Plant(){
       setLength(1);
       setTown("Columbus");
   }
   public Plant(int length, String town)
   {
       setLength(length);
       setTown(town);
   }
   public void setLength(int length){
       this.length = length;
   }
   public void setTown(String town){
       this.town = town;
   }
   public void feed (int amount){
        setLength(length + amount);
   }
   
   public void doSomethingWhenFed(){
       Random r = new Random();
       int x = r.nextInt(5);
       String[] action = {"Catches Fire", "Dances", "Changes color", "Does Nothing", "Dies"};
       System.out.println("The plant:" + action[x]);
   }
   public String toString(){
       return "Length: " + length + "\nTown: " + town;
    }
}
