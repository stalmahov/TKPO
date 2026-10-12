

namespace Lab1;
public class Teacher(string _name)
{
    
    public string Name{get;} = _name; 
    

    public void announceEnrollment(Course course)
    {
        course.openEnrollment(this);
    }
    public Grade gradeStudent(Enrollment _enrollment, int _value)
    {
        return new Grade(_value, _enrollment.Student, _enrollment.Course);
    }

    public override string ToString() => Name;

}