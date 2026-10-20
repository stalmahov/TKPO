namespace Lab2;
public interface IResultArchive
{
    void Save(Result result);
    List<Result> FindByStudent(Student student);
}
