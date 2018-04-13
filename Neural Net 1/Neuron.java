
/**
 * Write a description of class Neuron here.
 * 
 * Jacob Taylor
 */
public class Neuron
{
    private double weight;
    private int error;
    private int desOutput;
    private int actOutput;
    private int input;
    private double finalWeight;             
    public Neuron()
    {
       setWeight(0.0);       
    }
    
    public Neuron(double weight)
    {
       setWeight(weight);       
    }

    public void setWeight(double weight) {
        this.weight = weight;
    }
    
    public double getWeight() {
        return weight;
    }
    
    public void setFinal(double finalWeight) {
        this.finalWeight = finalWeight;
    }
    
    public double getFinal() {
        return finalWeight;
    }
    
    public void setError(int error) {
        this.error = error;
    }
    
    public int getError() {
        return error;
    }
    
    public void setDesired(int desOutput) {
        this.desOutput = desOutput;
    }
    
    public int getDesired() {
        return desOutput;
    }
    
    public void setActual(int actOutput) {
        this.actOutput = actOutput;
    }
    
    public int getActual() {
        return actOutput;
    }
    
    public void setInput(int input) {
        this.input = input;
    }
    
    public int getInput() {
        return input;
    }
}
