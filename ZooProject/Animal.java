import java.util.Random;
public class Animal implements Feedable
{   
    private static int foodInBowl;
       
    private String species;
    private boolean vertebra;
    private boolean carn;
    private int weight;
    
    public Animal(){
        setSpecies("cat");
        setVertebra(true);
        setCarn(true);
        setWeight(20);
    }
    public Animal(String species, int weight,
                  boolean vertebra, boolean carn){
        setSpecies(species);
        setVertebra(vertebra);
        setCarn(carn);
        setWeight(weight);
    }
    
    public void feed (int amount){
        setWeight(weight + amount);
    }
    public void doSomethingWhenFed(){
       Random r = new Random();
       int x = r.nextInt(5);
       String[] animalStates = {"Sleeping", "Taking a nap", "Going for a walk", "Having dessert", "Jumping"};
       System.out.println("Animal " + animalStates[x]);
       
   }
    public void setCarn(boolean carn){
        //carn = carn;
        this.carn = carn;
    }
    public final void setSpecies(String species){
        assert !species.equalsIgnoreCase("dinosaur");
        this.species = species;
    }    
    public  void setVertebra(boolean vertebra){
        this.vertebra = vertebra;
    }
    public void setWeight(int weight){
        this.weight = weight;
    }
    public void setFoodInBowl( int foodInBowl){
        this.foodInBowl = foodInBowl;
    }
    public String getSpecies(){
        return species;
    }  
    public boolean getCarn(){
        return carn;
    }   
    public boolean getVertebra(){
        return vertebra;
    }    
    public int getWeight(){
        return weight;
    }
    public int getFoodInBowl(){
        return foodInBowl;
    }
    public String toString(){
        return "Species: " + species + "\nHas bones: " + vertebra + 
               "\nEats meat: " + carn + "\nWeight: " + weight;
    }
    
}
