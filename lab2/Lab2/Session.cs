namespace Lab2;
public class Session(IResultArchive archive)
{
    private  List<Assessment> assessments = new();
    public void Add(Assessment assessment) => assessments.Add(assessment);
    public void ConductAll(Student student, List<int> scores)
    {
        if (scores.Count != assessments.Count) throw new ArgumentException("Scores count must match assessments count.");
        for (int i = 0; i < assessments.Count; i++)
        {
            assessments[i].Conduct(student);
            archive.Save(assessments[i].Assess(student, scores[i]));
        }
    }
}
