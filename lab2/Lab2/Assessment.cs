namespace Lab2;
public abstract class Assessment(string title) : IConductable, IAssessable
{
    public string Title { get; } = title;
    public abstract void Conduct(Student student);
    public abstract Result Assess(Student student, int score);
    public override string ToString() => Title;
}
