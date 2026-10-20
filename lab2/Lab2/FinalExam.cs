namespace Lab2;
public class FinalExam(string title, int ticketCount, List<string> commission) : Exam(title, ticketCount), IProtocolable
{
    public List<string> Commission { get; } = commission;
    public override void Conduct(Student student)
    {
        base.Conduct(student);
        if (Commission.Count == 0) throw new InvalidOperationException("Final exam has no commission.");
    }
    public string MakeProtocol() => $"Protocol: {Title}, commission: {string.Join(", ", Commission)}";
}
