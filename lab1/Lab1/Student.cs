namespace Lab1;
public class Student(string _name)

{
public string Name{get;} = _name;

public Enrollment enroll(Course _course)
    {
        return new Enrollment(this,_course);
    }
    public override string ToString() => Name;
}
