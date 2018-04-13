import java.util.Random;
import java.text.DecimalFormat;
/**
 * Write a description of class Trainer here.
 * 
 * @author (your name) 
 * @version (a version number or a date)
 */
public class Trainer
{   
    public static boolean finished = false;
    public static boolean first = true;
    //public final Object[][] table = new String[10][];
    public static void calError(Neuron x) {
        int error = x.getDesired() - x.getActual();
        x.setError(error);
    }

    public static void calNewWeights(Neuron a, Neuron b) {
        double deltaWeightA = .1 * a.getInput() * a.getError();
        double deltaWeightB = .1 * b.getInput() * b.getError();
        double newWeightA = a.getWeight() + deltaWeightA;
        a.setFinal(newWeightA);
        double newWeightB = b.getWeight() + deltaWeightB;
        b.setFinal(newWeightB);

    }
    
    public static void reassignWeights(Neuron a, Neuron b) {
        a.setWeight(a.getFinal());
        b.setWeight(b.getFinal());
    }
    
    public static void Trial(Neuron a, Neuron b, int count){
        if(count == 1) {
            a.setInput(0);
            b.setInput(0);
            a.setDesired(0);
            b.setDesired(0);
        } else if (count == 2){
            a.setInput(0);
            b.setInput(1);
            a.setDesired(0);
            b.setDesired(0);
        } else if (count == 3) {
            a.setInput(1);
            b.setInput(0);
            a.setDesired(0);
            b.setDesired(0);
        } else {
            a.setInput(1);
            b.setInput(1);
            a.setDesired(1);
            b.setDesired(1);
        }
            
        int actual;
        double threshold = .2;
        double outputVal = (a.getWeight() * a.getInput()) + (b.getWeight() * b.getInput()) - threshold;
        if (outputVal < 0) {
            a.setActual(0);
            b.setActual(0);
        } else {
            a.setActual(1);
            b.setActual(1);
        }

    }
    public static void UpdateTable(int epoCount, int input1, int input2, int desired, double weight1, double weight2, int actual, int error, double final1, double final2) {
        if(first == true) {
            first = false;
            
            System.out.println("Epoch" + "\t" + "X1" + "\t" + "X2" + "\t" + "Desired Output" + "\t" + "W1 initial" + "\t" + "W2 initial" + "\t" + "Actual Output" + "\t" + "Error" + "\t" + "W1 Final" + "\t" + "W2 Final");
            DecimalFormat df = new DecimalFormat("#.##");    
            
            System.out.print(epoCount);
            System.out.print("\t" + input1);
            System.out.print("\t" + input2);
            System.out.print("\t" + desired);
            System.out.print("\t \t" + df.format(weight1));
            System.out.print("\t \t" + df.format(weight2));
            System.out.print("\t \t" + actual);
            System.out.print("\t \t" + error);
            System.out.print("\t" + df.format(final1));
            System.out.println("\t \t" + df.format(final2));          
            
            
        } else {
            DecimalFormat df = new DecimalFormat("#.##");    
            
            System.out.print(epoCount);
            System.out.print("\t" + input1);
            System.out.print("\t" + input2);
            System.out.print("\t" + desired);
            System.out.print("\t \t" + df.format(weight1));
            System.out.print("\t \t" + df.format(weight2));
            System.out.print("\t \t" + actual);
            System.out.print("\t \t" + error);
            System.out.print("\t" + df.format(final1));
            System.out.print("\t \t" + df.format(final2));          
            
            
            System.out.println();          
        }

          
          
          
          
    }
    public static void main (String[] args) {
        Random r = new Random();

        double ranWeight1 = -0.5 + (0.5 - -0.5) * r.nextDouble();                
        Neuron neuro1 = new Neuron(ranWeight1);

        double ranWeight2 = -0.5 + (0.5 - -0.5) * r.nextDouble();
        Neuron neuro2 = new Neuron(ranWeight2);

        int epochCounter = 1;
        int trialCounter = 1;

        int er1 = 1;
        int er2 = 1;
        int er3 = 1;
        int er4 = 1;
        int z = 0;
        while(finished == false) {
            for(int i = 0; i < 4; i++) {
                Trial(neuro1, neuro2, trialCounter);
                calError(neuro1);
                calError(neuro2);
                calNewWeights(neuro1, neuro2);
                UpdateTable(epochCounter, neuro1.getInput(), neuro2.getInput(), neuro1.getDesired(), neuro1.getWeight(), neuro2.getWeight(), neuro1.getActual(), neuro1.getError(), neuro1.getFinal(), neuro2.getFinal());
                if(i == 0){
                    er1 = neuro1.getError();
                } else if (i == 1){
                    er2 = neuro1.getError();
                } else if (i == 2) {
                    er3 = neuro1.getError();
                } else {
                    er4 = neuro1.getError();
                }
                reassignWeights(neuro1, neuro2);
                trialCounter++;
            }
            System.out.println();            
            trialCounter = 1;
            epochCounter++;
            z++;
            if((er1 == 0) && (er2 == 0) && (er3 == 0) && (er4 == 0))  {
                finished = true;
            } else {
                finished = false;
            }
        }
    }
}
