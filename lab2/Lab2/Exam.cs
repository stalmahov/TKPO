namespace Lab2;
public class Exam(string title, int ticketCount) : Assessment(title)
{
    public int TicketCount { get; } = ticketCount;
    public override void Conduct(Student student)
    {
        if (TicketCount <= 0) throw new InvalidOperationException("Exam has no tickets.");
    }
    public override Result Assess(Student student, int score) => new(student, this, score);
}
