namespace Lab1;
public class Grade(int _value, Student _student, Course _course)
{


public int Value{get;} = _value;
public Student Student{get;} = _student;
public Course Course{get;}= _course;


    public override string ToString() => $"Оценка: {Value}, Студент: {Student.Name}, Курс: {Course.Title}";




}