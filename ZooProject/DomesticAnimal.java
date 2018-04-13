public class DomesticAnimal extends Animal
{
   private String homeTown;
   
   public DomesticAnimal(){
       super();//Super is Animal
       setHomeTown("Columbus");
   }
   
   public DomesticAnimal(String species, int weight,
                  boolean vertebra, boolean carn, String homeTown){
        super(species, weight, vertebra, carn);
        setHomeTown(homeTown);
       }
   public void setVertebra(boolean vertebra){
       if(vertebra == false){
           System.out.println("Sorry, Domestic Animal must have bones");
           return;
       }
        super.setVertebra(vertebra);
    }
    
   public void setHomeTown(String homeTown){
       this.homeTown = homeTown;
    }
    public String getHomeTown(){
        return homeTown;
    }    
    public String toString(){
        return super.toString() + "\nHomeTown: " + homeTown;
    }
}
