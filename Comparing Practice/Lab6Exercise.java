import java.util.Arrays;
import java.util.LinkedList;
import java.util.Random;
import java.util.List;
import java.lang.Math;
import java.util.Collections;
/**
 * Write a description of class Lab6Exercise here.
 * 
 * @author (your name) 
 * @version (a version number or a date)
 */
public class Lab6Exercise
{       
    public static void main (String [] args)
    {
        List<String> firstNameBank = new LinkedList<String>(Arrays.asList("Abraham", "Baxton", "Charles", "Darnell", "Eddy", "Fabian", "Greg", "Heather", "Ingred", "Jericho", "Keanu", "Leon", "Mariah", "Noah", "Orion", "Perry", "Quinton", "Randall", "Sylvester", "Tanya", "Udyr", "Vincent", "Wilson", "Xavier", "Yugi", "Zachariah")); 
        List<String> lastNameBank = new LinkedList<String>(Arrays.asList("Aires", "Brown", "Clinton", "Drogo", "Erikson", "Flamingo", "Geronimo", "Hanzo", "Israel", "Jaurez", "Kasheem", "Lawrence", "Morgans", "Nichols", "Obando", "Perez", "Quartz", "Reeves", "Smith", "Taylor", "Undras", "Vargez", "Williams", "Xande", "Yan", "Zhou")); 
        List<Student> students = new LinkedList<Student>();
        Random r = new Random();        
        for (int i = 0; i<20; i++)
        {  
            int randFirst = r.nextInt(firstNameBank.size());
            String fName = firstNameBank.get(randFirst);
            int randLast = r.nextInt(lastNameBank.size());
            String lName = lastNameBank.get(randLast);
            double randGPA = (4.0) * r.nextDouble();
            randGPA = Math.round(randGPA * 100.00) / 100.00;
            int randID = r.nextInt(3000) + 2000;
            Student s1 = new Student(randID, fName, lName, randGPA);
            students.add(s1);               
        }
        System.out.println("Unsorted list of students:");
        System.out.println();
        printStudent(students);
        System.out.println();
        System.out.println("Sorted by GPA in descending order:");        
        Collections.sort(students, Collections.reverseOrder( new GradeComparator()));
        System.out.println();
        printStudent(students);
        System.out.println();
        System.out.println("Sorted by first names in ascending order, if first names are the same, then it is sorted by last names in ascending order,\nif last names are also the same, then it is sorted by GPA in ascending order:");
        System.out.println();
        Collections.sort(students, new FirstNameComparator());
        printStudent(students);
        System.out.println();
        System.out.println("Sorted by last name in descending order, if the last names are the same, then it is sorted by GPA in descending order:");
        Collections.sort(students, Collections.reverseOrder(new LastNameComparator()));
        System.out.println();
        printStudent(students);
        System.out.println();
    }
    public static void printStudent(List<Student> x)
    {
        for ( int i = 0; i< x.size(); i++)
        {
            int num = i+1;
            Student a = x.get(i);
            System.out.println("Student Number " + num + ". " + a.toString());
        }
        
    }
}
