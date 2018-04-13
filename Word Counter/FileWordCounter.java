import java.util.Scanner;
import java.io.File;
import java.util.HashMap;
import java.util.Collections;
import java.io.*;
import java.util.*;
/**
 * Write a description of class FileWordCounter here.
 * 
 * @author (your name) 
 * @version (a version number or a date)
 */
public class FileWordCounter
{

    public static void main(String args[])
    {
        int wordCount = 0;
        System.out.println("Enter a file name you would like to examine");
        Scanner fileScan = new Scanner(System.in);
        String fileInput = fileScan.nextLine();
        File story = new File(fileInput);
        HashMap<String, Word> paragraph = new HashMap<String, Word>();
        try{

            Scanner lineScanner = new Scanner(fileInput);
            while(lineScanner.hasNext())
            {
                String currentWord = lineScanner.next();
                if(paragraph.containsKey(currentWord) == true)
                {
                    Word old = paragraph.get(currentWord);
                    old.setCount(old.getCount() + 1);

                }
                else
                {
                    Word newWord = new Word(currentWord, 1);
                    paragraph.put(currentWord, newWord);
                }
                wordCount++;
            }

            String updateFile = story + "." + Calendar.getInstance().getTimeInMillis();
            PrintWriter out = new PrintWriter(updateFile);
            out.println("The paragraph has " + wordCount + " words. The frequency of the letters is as follows: ");
            for(String word : paragraph.keySet())
            {
                out.println(paragraph.get(word).toString());
            }
            out.close();
        } catch(IOException e){
            System.out.println("File not found!!!");
        }
        System.out.println("The paragraph has " + wordCount + " words. The frequency of the letters is as follows: ");
        for(String word : paragraph.keySet())
        {
            System.out.println(paragraph.get(word).toString());
        }
    }
}
