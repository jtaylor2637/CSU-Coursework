import java.io.*;
import java.util.*;
public class ColumbusZoo
{
    public static void addHelper(ArrayList<DomesticAnimal> a){
        Scanner s = new Scanner(System.in);
        System.out.println("What species");

        String usrSpecies = s.nextLine();

        DomesticAnimal toBeAdded = new DomesticAnimal(usrSpecies, 10, true, true, "Gutters");
        a.add(toBeAdded);
    }

    public static void main(String[] args) throws FileNotFoundException{
        DomesticAnimal da = new DomesticAnimal();
        ArrayList<DomesticAnimal> animals = new ArrayList<DomesticAnimal>();

        try{
            File dAnimals = new File("domesticanimals.txt");
            Scanner aAnimalScanner = new Scanner(dAnimals);

            int foodInBowl = Integer.parseInt(aAnimalScanner.nextLine());
            System.out.println(foodInBowl);

            while(aAnimalScanner.hasNext())
            {
                String species = aAnimalScanner.nextLine();
                String vertebra = aAnimalScanner.nextLine();
                String carn = aAnimalScanner.nextLine();
                int weight = Integer.parseInt(aAnimalScanner.nextLine());
                String homeTown = aAnimalScanner.nextLine();

                boolean boolVertebra = false;
                if(vertebra.equals("true"))boolVertebra = true;
                boolean boolCarn = false;
                if(carn.equals("true"))boolCarn = true;
                da = new DomesticAnimal(species, weight, 
                    boolVertebra, boolCarn, homeTown);
                da.setFoodInBowl(foodInBowl);
                animals.add(da);
            }
        }catch(IOException e){
            System.out.println("File of domestic animals not found !!!");
        }
        System.out.println("****Welcome to Columbus Zoo*******");
        System.out.println("And here are the domestic animals..");
        System.out.println("***********************************");
        for(int i = 0; i< animals.size(); i++){
            System.out.println(animals.get(i).toString());
        }
        
        WildAnimal wa = new WildAnimal();
        ArrayList<WildAnimal> wildAnimals = new ArrayList<WildAnimal>();

        try{
            File wAnimals = new File("wildanimals.txt");
            Scanner bAnimalScanner = new Scanner(wAnimals);

            int foodInBowl = Integer.parseInt(bAnimalScanner.nextLine());
            System.out.println(foodInBowl);

            while(bAnimalScanner.hasNext())
            {
                String species = bAnimalScanner.nextLine();
                String vertebra = bAnimalScanner.nextLine();
                String carn = bAnimalScanner.nextLine();
                int weight = Integer.parseInt(bAnimalScanner.nextLine());
                String habitat = bAnimalScanner.nextLine();
                boolean boolVertebra = false;
                if(vertebra.equals("true"))boolVertebra = true;
                boolean boolCarn = false;
                if(carn.equals("true"))boolCarn = true;
                wa = new WildAnimal(species, weight, 
                    boolVertebra, boolCarn, habitat);
                wa.setFoodInBowl(foodInBowl);
                wildAnimals.add(wa);
            }
        }catch(IOException e){
            System.out.println("File of Wild animals not found !!!");
        }
        System.out.println("****Welcome to Columbus Zoo*******");
        System.out.println("And here are the wild animals..");
        System.out.println("***********************************");
        for(int i = 0; i< wildAnimals.size(); i++){
            System.out.println(wildAnimals.get(i).toString());
        }
        Plant p1 = new Plant();
        ArrayList<Plant> plantlist = new ArrayList<Plant>();

        try{
            File plantfile = new File("plants.txt");
            Scanner aPlantScanner = new Scanner(plantfile);

            

            while(aPlantScanner.hasNext())
            {
                int length = Integer.parseInt(aPlantScanner.nextLine());
                String town = aPlantScanner.nextLine();

                
                p1 = new Plant(length, town);
                
                plantlist.add(p1);
            }
        }catch(IOException e){
            System.out.println("File of plants not found !!!");
        }
        System.out.println("****Welcome to Columbus Zoo*******");
        System.out.println("And here are the plants.");
        System.out.println("***********************************");
        for(int i = 0; i< plantlist.size(); i++){
            System.out.println(plantlist.get(i).toString());
        }
        int choice = 1;
        do{
            System.out.print("Press (1) to add a domestic animal and (0) to exit: ");
            Scanner input = new Scanner(System.in);
            choice = Integer.parseInt(input.nextLine());

            switch(choice){
                case 1:
                addHelper(animals);
                break;
                case 0:
                System.out.println("You selected 0.");
                default:
                System.out.println("Invalid choice.");
            }
            System.out.println("And here are the domestic animals..");
            System.out.println("***********************************");
            for(int i = 0; i< animals.size(); i++){
                System.out.println(animals.get(i).toString());
            }

        }while(choice != 0);

        //Getting Ready to write back out to the file
        System.out.println("Saving the updates list of domestic animals");
        PrintWriter out = new PrintWriter("domesticanimals.txt");

        int foodAmount = animals.get(0).getFoodInBowl();
        out.println(foodAmount);

        for(int i = 0; i < animals.size(); i++){

            out.println(animals.get(i).getSpecies());
            out.println(animals.get(i).getCarn());
            out.println(animals.get(i).getVertebra());
            out.println(animals.get(i).getWeight());
            out.println(animals.get(i).getHomeTown());
            System.out.println(" Saved " + animals.get(i).getSpecies());
        }
        out.close();

        System.out.println("Thank you visiting my zoo");
    }

}
