namespace Lab1;
public class Enrollment(Student _student, Course _course)

{
public Student Student{get;} = _student;
public Course Course{get;} = _course;


    public override string ToString() => $"Запись: {Student} на курсе \"{Course.Title}\"";
}