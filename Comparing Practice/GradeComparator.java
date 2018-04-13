import java.util.Comparator;
/**
 * compares gpa in descending order
 * 
 * @author (your name) 
 * @version (a version number or a date)
 */
public class GradeComparator implements Comparator<Student>
{
    public int compare(Student a, Student b)
    {
        return Double.compare(a.getGrade(), b.getGrade());        
    }
}
