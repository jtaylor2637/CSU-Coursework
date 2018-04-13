import java.lang.Character;
import java.util.ArrayList;
import java.util.Random;
import java.lang.Math;
import java.lang.StringBuilder;
import java.lang.Integer;
import java.lang.Double;
import java.io.*;
import java.util.*;
/**
 * Write a description of class GenomeTester here.
 * 
 * @Jacob Taylor
 * @version (a version number or a date)
 */
public class GenomeTester
{   
    //initialize variables
    private static ArrayList<Genome> population = new ArrayList<Genome>();
    private static int populationSize = 0;
    private static double crossoverRate = .07;
    private static double mutationRate = .001;
    private static int genNum = 0;
    private static String fileTitle;
    private static int runCounter = 1;
    private static double avg;
    private static double best;
    private static boolean close = false;
    private static boolean finished = false;
    private static int avgGen = 0;
    /* Method returns a random genome from the population of the appropriate length
     * 
     */
    public static Genome randomGenome(int length){
        boolean found = false;
        Random rand = new Random();
        ArrayList<Genome> appLength = new ArrayList<Genome>();
        Genome selected = new Genome(length);
        for(Genome gene : population) { //goes through the population and adds all genomes of appropriate length
            if(gene.getLength() == length) {
                appLength.add(gene);
            }
        }
        while(found == false) { //finds a random genome of the list of genomes and returns it
            int val = rand.nextInt(appLength.size());
            if(appLength.get(val).getLength() == length) {
                found = true;
                selected = appLength.get(val);
            }

        }
        return selected;
    }

    /*
     * creates the initial population, an arraylist of genomes consisting of random bit strings
     */
    public static void makePopulation(int size, int length) {
        genNum = 0;
        for(int i = 0; i <= size - 1; i++) {
            String theBits = createRandomBitString(length);
            Genome a = new Genome(length, theBits);
            population.add(a);

        }
        genNum++;
    }

    /*
     * creates child population by selecting two parent genes, performing crossover and mutation if the random value is within range
     * of the rates and repeating the process until the child population is full
     */
    public static void makeChildPopulation(int size, int length) {
        ArrayList<Genome> children = new ArrayList<Genome>();
        while(children.size() != size){
            Genome parent1 = selectPair(population);
            Genome parent2 = selectPair(population);

            if(Math.random() <= crossoverRate) {
                ArrayList<Genome> crosses = crossOver(parent1, parent2);
                for(Genome gene: crosses) {
                    Genome mut = mutate(gene, mutationRate);
                    children.add(mut);
                }
            } else {
                Genome mut1 = mutate(parent1, mutationRate);
                Genome mut2 = mutate(parent2, mutationRate);
                children.add(mut1);
                children.add(mut2);
            }
        }
        population = children;
        genNum++;
    }

    /*
     * helper method to print out the population
     */
    public static void printPopulation(ArrayList<Genome> pop){
        for(Genome gene : pop) {
            System.out.println(gene.getString());
        }
    }

    /*
     * creates the string for the genome by using random numbers to assign each character as a 0 or 1
     */
    public static String createRandomBitString(int length) {
        String bits = "";
        for(int i = 0; i <= length - 1; i++){
            if (Math.random() < 0.5) {
                bits+= "0";
            } else {
                bits+= "1";
            }
        }
        return bits;
    }

    /*
     * assess the genome's fitness by counting every occurance of the bit 1
     */
    public static int fitnessAssess(Genome gene) {
        String bits = gene.getString();
        int fitCount = 0;
        for(char ch: bits.toCharArray()){
            if(ch == '1') {
                fitCount++;
            }
        }
        return fitCount;
    }
    /*
    public static double[] evaluateFitness(ArrayList<Genome> pop){
    double bestFit = -1.0;
    double averageFit = 0.0;
    double currentFit = 0.0;
    for(Genome gene: pop) {
    currentFit = (double)fitnessAssess(gene);
    averageFit += currentFit;
    if(bestFit == -1) {
    bestFit = currentFit;
    } else {
    if(currentFit > bestFit) {
    bestFit = currentFit;
    }
    }             
    }
    averageFit = (averageFit / (double)pop.size());
    avg = averageFit;
    best = bestFit;
    //System.out.println("Best" + bestFit);
    return new double[]{averageFit, bestFit};
    }   */

    /*
     * calculates the average fitness and best fitness of a population
     */

    public static void evaluateTheFitness(ArrayList<Genome> pop){
        avg = 0.0;
        best = 0.0;
        double bestFit = -1.0;
        double averageFit = 0.0;
        double currentFit = 0.0;
        for(Genome gene: pop) { // iterate through the population
            currentFit = (double)fitnessAssess(gene); 
            averageFit += currentFit; //sum up each gene's fitness
            if(bestFit == -1) { //if first iteration best fitness is the first gene
                bestFit = currentFit;
            } else {
                if(currentFit > bestFit) { //if current fitness is better than best fitness reassign best
                    bestFit = currentFit;
                }
            }             
        }
        averageFit = (averageFit / (double)pop.size());
        avg = averageFit;
        best = bestFit;
        //System.out.println("Best" + bestFit);

    }

    /*
     * performs crossover of two genomes and returns an arraylist of the two genomes
     */
    public static ArrayList<Genome> crossOver(Genome a, Genome b) {
        String one = a.getString();
        String two = b.getString();

        Random rand = new Random(); 
        int crossover = rand.nextInt(one.length() - 1) + 1; //random crossover point that is not the first or last bit in the string
        //System.out.println("Crossover point " + crossover);
        String c = one.substring(0, crossover); //first half of 1
        c += two.substring(crossover, two.length()); //second half 2

        String d = two.substring(0, crossover); //first half of 2
        d += one.substring(crossover, one.length()); //second half of 1

        ArrayList<Genome> crossovers = new ArrayList<Genome>();
        Genome a1 = new Genome(one.length(), c);
        crossovers.add(a1); 
        Genome a2 = new Genome(two.length(), d);
        crossovers.add(a2);
        //add the bitstring to genomes and add genomes to arraylist
        return crossovers;
    }

    /*
     * performs mutation at a random point
     */
    public static Genome mutate(Genome mut, double mutRate){
        if(Math.random() <= mutRate){ //if mutation needs to occur
            Random rand = new Random();
            int mutPoint = rand.nextInt(mut.getLength()); //random point to mutate
            //System.out.println("Mutation Point " + mutPoint);
            StringBuilder bits = new StringBuilder(mut.getString()); //builder to help modifiy string

            if(bits.charAt(mutPoint) == '0') { //changes bit to opposite value
                bits.setCharAt(mutPoint, '1');
            } else {
                bits.setCharAt(mutPoint, '0');
            }
            String bitsy = bits.toString(); //string version of bitstring
            Genome mutatedGene = new Genome(mut.getLength(), bitsy);
            return mutatedGene;
        } else { //return original if unmutated
            return mut;
        }

    }

    /*
     * helper method for finding random
     */
    public static double randUniformPositive() {
        return new Random().nextDouble();
    }

    /*
     * gets a genome based on roulette wheel selection to be used for the population
     * referenced from wikipedia code to obtain direction of how to accomplish this
     */
    public static Genome selectPair(ArrayList<Genome> pop) {

        ArrayList<Genome> genes = new ArrayList<Genome>();

        double fitSum = 0;

        for(Genome gene: pop) { //calculate total fitness sum of the population
            fitSum += (double)fitnessAssess(gene);            
            // get a random value

        }
        double value = randUniformPositive() * fitSum;  //get random value 
        for(Genome gene: pop) { // if the gene selected makes the value <= 0 select this gene
            value -= (double)fitnessAssess(gene);     
            if(value <= 0) return(gene);
        }
        // when rounding errors occur, we return the last item's index 

        return (pop.get(pop.size() - 1));

    }     

    /*public static void generationInfo(double[] fitness){
    System.out.print("Generation " + genNum);
    System.out.print(" : Average Fitness ");
    System.out.printf("%.2f", fitness[0]);
    System.out.print(" , Best Fitness ");
    System.out.printf("%.2f", fitness[1]);
    //System.out.printf("Generation " + genNum + ": Average Fitness %.2f" + fitness[0] + ", Best Fitness %.2f" + fitness[1]); 
    }*/

    /*
     * printer method to help format output to screen
     */
    public static void generationalInfo(){
        System.out.print("Generation " + genNum);
        System.out.print(" : Average Fitness ");
        System.out.printf("%.2f", avg);
        System.out.print(" , Best Fitness ");
        System.out.printf("%.2f", best);
         
    }
    /*
     * uses casted writers to append each generation's info to the file it is currently on
     */
    public static void writeRun(String fileName){
        try {
            
            FileWriter fw = new FileWriter(fileName, true);
            BufferedWriter bw = new BufferedWriter(fw);
            PrintWriter out = new PrintWriter(bw);
            //PrintWriter writer = new PrintWriter(new FileOutputStream(fileTitle, true));
            out.print("Generation " + genNum);           
            out.print(" : Average Fitness ");
            out.printf("%.2f", avg);
            out.print(" , Best Fitness ");
            out.printf("%.2f", best);
            out.println("");
            out.flush();
            //}
            if(close == true){
                out.close();
            }
        } catch(IOException e) {
            System.out.println("File error");
        }
    }
    /*
     * does the final write out to the table file to calculate the avg generation found and the location for each run.
     */
    public static void writeTable(int y){
        try {
            if(finished != true) { //while program is not ready to be completed continue appending to file and increasing sum
                FileWriter fw = new FileWriter("outputTable.txt", true);
                BufferedWriter bw = new BufferedWriter(fw);
                PrintWriter out = new PrintWriter(bw);
                //PrintWriter writer = new PrintWriter(new FileOutputStream(fileTitle, true));
                out.print("Run: " + runCounter);
                out.print(" Generation " + genNum);
                avgGen += genNum;

                out.println("");
                out.flush();
                //}
                if(close == true){
                    //int navgGen = avgGen / y;
                    //out.print("Average generation found " + navgGen);
                    out.println("");
                    out.flush();
                    out.close();
                }
            } else { //calculate the average and write and close the file
                FileWriter fw = new FileWriter("outputTable.txt", true);
                BufferedWriter bw = new BufferedWriter(fw);
                PrintWriter out = new PrintWriter(bw);
                int navgGen = avgGen / y;
                out.print("Average generation found " + navgGen);
                out.println("");
                out.flush();
                out.close();
            }
            

        } catch(IOException e) {
            System.out.println("File error");
        }
    }
    /*
     * main method, takes in command line arguments in form of {"100", "0.7", "0.001", "run1.txt"}
     *     where 100 is the pop size, .7 is the crossover rate, .001 is the mutation rate and run1.txt is the run file
     */
    public static void runGA(String[] args) {
        boolean writing = false;
        if(args.length > 0){ //parsing command line arguments and assigning values to be used
            for(int i = 0; i <= args.length - 1; i++){
                if(i == 0) {
                    int size = Integer.parseInt(args[i]);
                    populationSize = size;
                } else if(i == 1) {
                    double crossR = Double.parseDouble(args[i]);
                    crossoverRate = crossR;
                } else if(i == 2){
                    double mutR = Double.parseDouble(args[i]);
                    mutationRate = mutR;
                } else if(i == 3) {
                    String fileName = (args[i]);
                    fileTitle = fileName;
                    writing = true;
                } else {
                    System.out.println("No more arguments");
                }

            }
        }
        
        //reseting variables for new iterations
        population.clear();
        best = 0.0;
        avg = 0;
        avgGen = 0;
        runCounter = 1;        

        /*
        if(writing == true) {
        int r = Character.getNumericValue(fileTitle.charAt(3));
        }

        population.clear();
        best = 0.0;
        avg = 0;
        makePopulation(populationSize, 20);
        boolean perfect = false;
        //double result[] = evaluateFitness(population);
        evaluateTheFitness(population);
        generationalInfo();
        if(writing == true) {
        writeRun(fileTitle);
        }

        System.out.println();
        if(best == (20.0)) {
        perfect = true;            
        }
        while(perfect == false){

        makeChildPopulation(populationSize,20);
        //double nextResult[] = evaluateFitness(population);
        evaluateTheFitness(population);

        if(best == (20.0)) {
        perfect = true;
        close = true;
        writeTable(r);
        }
        generationalInfo();
        if(writing == true) {
        writeRun(fileTitle);
        }
        System.out.println();

        }      
        System.out.println("Results saved in file " + fileTitle);
        finished = true;
        writeTable(r);
         */

        
        //run size
        int y = 50;
        System.out.println("Run " + runCounter);
        for(int x = 1; x <= y; x++){//does 50 runs
            //building file name string based on run number
            String curFileName = "run";
            curFileName += Integer.toString(x);
            curFileName += ".txt";
            population.clear();
            best = 0.0;
            avg = 0;
            //make initial population
            makePopulation(populationSize, 20);
            
            boolean perfect = false;
            //evaluate the population and get the information for the pop
            evaluateTheFitness(population);
            generationalInfo();
            //write to file
            writeRun(curFileName);
            System.out.println();
            
            if(best == (20.0)) {//if perfect gene is found at first generation, stop
                perfect = true;            
            }
            while(perfect == false){ //otherwise make child populations and continue searching until perfect gene is found

                makeChildPopulation(populationSize,20);

                evaluateTheFitness(population);

                if(best == (20.0)) {
                    perfect = true;
                    close = true;
                    writeTable(y);
                }
                generationalInfo();
                writeRun(curFileName);
                System.out.println();

            }
            
            
            System.out.println("Results saved in file " + curFileName); //tells user write complete
            runCounter++;
            if(x != y){ //prints new run to help indicate next run
                System.out.println("Run " + runCounter);
            }
        }
        //finishes and writes last avg calculation to table
        finished = true;
        writeTable(y);

    }
}
