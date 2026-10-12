namespace Lab1;
public class InMemoryArchive : IArchive
{
    private List<Grade> grades = [];
    public void save(Grade _grade)
    {
        grades.Add(_grade);
    }
    public List<Grade> findByStudent(Student _student)
    {
        return grades.FindAll(g => g.Student == _student);
    }
    public override string ToString() =>
        grades.Count == 0 
            ? "Архив пуст" 
            : string.Join(Environment.NewLine, grades);
}