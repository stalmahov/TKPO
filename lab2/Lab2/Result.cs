namespace Lab2;
public class Result(Student student, Assessment assessment, int score)
{
    public Student Student { get; } = student;
    public Assessment Assessment { get; } = assessment;
    public int Score { get; } = score;
    public override string ToString() => $"Result: {Student} - {Assessment}: {Score}";
}
