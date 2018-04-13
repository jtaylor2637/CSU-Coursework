import java.util.Comparator;
/**
 * compares last names, if equal sorts by gpa in descending order
 * 
 * @author (your name) 
 * @version (a version number or a date)
 */
public class LastNameComparator implements Comparator<Student>
{
    public int compare(Student a, Student b)
    {
        if(a.getLastName().compareTo(b.getLastName())== 0)
        {
            return Double.compare(a.getGrade(), b.getGrade());
        }
        else
        {
            return a.getLastName().compareTo(b.getLastName());
        }
    }
}
