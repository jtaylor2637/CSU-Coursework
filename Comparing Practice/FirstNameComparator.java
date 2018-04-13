import java.util.Comparator;
/**
 * compares first names, if equal, compares last names, if equal, compares gpa prints in ascending order
 * 
 * @author (your name) 
 * @version (a version number or a date)
 */
public class FirstNameComparator implements Comparator<Student>
{
    public int compare(Student a, Student b)
    {
        if (a.getFirstName().compareTo(b.getFirstName())==0)
        {
            if(a.getLastName().compareTo(b.getLastName())==0)
            {
              return Double.compare(a.getGrade(), b.getGrade());
            }
            else
            {
              return a.getLastName().compareTo(b.getLastName());
            }
        }
        else
        {
             return a.getFirstName().compareTo(b.getFirstName());
        }
    }    
}
