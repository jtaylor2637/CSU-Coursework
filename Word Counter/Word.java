
/**
 * Write a description of class Word here.
 * 
 * @author (your name) 
 * @version (a version number or a date)
 */
public class Word <Word extends Comparable>
{
    private String contents;
    private int count;
    /**
     * Constructor for objects of class Word
     */
    public Word(String word, int frequency)
    {
        setContents(word);
        setCount(frequency);
    }

    public void setContents(String contents)
    {
        this.contents = contents;
    }

    public String getContents()
    {
        return contents;
    }

    public void setCount(int count)
    {
        this.count = count;
    }

    public int getCount()
    {
        return count;
    }
    
    
    
    public String toString()
    {
        return "Word: " + getContents() + " Count: " + getCount();
    }
    
    
}
