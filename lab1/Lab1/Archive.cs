namespace Lab1;
public interface IArchive
{
    public void save(Grade _grade);
    public List<Grade> findByStudent(Student _student);
    
}