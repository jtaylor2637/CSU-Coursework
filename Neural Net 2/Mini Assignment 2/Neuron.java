
/**
 * Write a description of class Neuron here.
 * 
 * Jacob Taylor
 */
public class Neuron
{
    private int[][] weight;
    private int[][] desOutput;
    private int[][] actOutput;
    private int[][] input;
    private int[][] pastInput;
    
    
    public Neuron(int[][] weight)
    {
       setWeight(weight);       
    }

    public void setWeight(int[][] weight) {
        this.weight = weight;
    }
    
    public int[][] getWeight() {
        return weight;
    }       
    
    public void setDesired(int[][] desOutput) {
        this.desOutput = desOutput;
    }
    
    public int[][] getDesired() {
        return desOutput;
    }
    
    public void setActual(int[][] actOutput) {
        this.actOutput = actOutput;
    }
    
    public int[][] getActual() {
        return actOutput;
    }
    
    public void setInput(int[][] input) {
        this.input = input;
    }
    
    public int[][] getInput() {
        return input;
    }
    
    public void setPastInput(int[][] pastInput) {
        this.input = input;
    }
    
    public int[][] getPastInput() {
        return pastInput;
    }
    
    
}
