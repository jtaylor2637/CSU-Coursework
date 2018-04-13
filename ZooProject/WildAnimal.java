public class WildAnimal extends Animal
{
    private String habitat;
    
    public WildAnimal(){
        super();
        setHabitat("Amazon");
    }
    
    public WildAnimal(String species, int weight,
                  boolean vertebra, boolean carn, String habitat){
        super(species, weight, vertebra, carn);
        setHabitat(habitat);
    }
    public void setHabitat(String habitat){
       this.habitat = habitat;
    }
    public String getHabitat(){
        return habitat;
    }
    
    public String toString(){
        return super.toString() + "\nHabitat: " + habitat;
    }
}
