import java.util.ArrayList;
import java.lang.Character;
import java.lang.Math;
/**
 * Write a description of class Genome here.
 * 
 * @author (your name) 
 * @version (a version number or a date)
 */
public class Genome
{
    private ArrayList<Integer> a;
    private int oriLength;
    
    
    public Genome(int length){
        a = new ArrayList<Integer>(length);
        oriLength = length;        
        
    }
    
    public Genome(int length, String bitString){
        a = new ArrayList<Integer>(length);
        oriLength = length;        
        for (char ch : bitString.toCharArray()) {
            a.add(Character.getNumericValue(ch));
        }
    }
    
    public int getLength() {
        return a.size();
    }   
        
    public ArrayList<Integer> getList() {
        return a;
    }
    
    public void insertValue(int num){        
        a.add(num);
    }
    public String getString() {
        String bits = "";
        for(int i = 0; i <= a.size() - 1; i++){
            bits += Integer.toString(a.get(i));
        }
        return bits;
    }
    public void createRandomBitString(int length) {
        a.clear();
        for(int i = 0; i <= length - 1; i++){
            if (Math.random() < 0.5) {
                a.add(0);
            } else {
                a.add(1);
            }
        }
    }
}
