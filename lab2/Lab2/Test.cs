namespace Lab2;
public class Test(string title, int questionCount) : Assessment(title)
{
    public int QuestionCount { get; } = questionCount;
    public override void Conduct(Student student)
    {
        if (QuestionCount <= 0) throw new InvalidOperationException("Test has no questions.");
    }
    public override Result Assess(Student student, int score) => new(student, this, score);
}
