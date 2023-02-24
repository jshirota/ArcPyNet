namespace ArcPy;

public record Variable
{
    public string Name { get; }
    public string Json { get; }

    public Variable(string name, string json)
    {
        this.Name = name;
        this.Json = json;
    }

    public override string ToString()
    {
        return this.Name;
    }
}

public interface IVariable
{
    public Variable Variable { get; }
}
