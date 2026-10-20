namespace Lab2;
public class InMemoryResultArchive : IResultArchive
{
    private List<Result> results = new();
    public void Save(Result result) => results.Add(result);
    public List<Result> FindByStudent(Student student) => results.Where(r => r.Student == student).ToList();
}
