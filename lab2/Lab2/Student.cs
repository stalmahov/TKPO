namespace Lab2;
public class Student(string name)
{
    public string Name { get; } = name;
    public override string ToString() => Name;
}
