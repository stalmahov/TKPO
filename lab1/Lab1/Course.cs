namespace Lab1;
public class Course(string _title, Teacher _teacher)
{
    public string Title {get;} = _title;
    public Teacher Teacher{get;} = _teacher;
    public bool EnrollmentOpen{get; private set;} 
    public List<Enrollment> Enrollments {get;} =[];

    
    public void openEnrollment(Teacher _teacher)
    {// дописать валидацию учителя.
    EnrollmentOpen = true;
        
    } 
    public void addEnrollment(Enrollment _enrollment)
    {
        Enrollments.Add(_enrollment);
    }
    public override string ToString() => $"Название курса: {Title}, Преподаватель: {Teacher}, Открыт набор: {EnrollmentOpen}, Записи [{Enrollments.Count}]: {string.Join("; ", Enrollments)}";
}