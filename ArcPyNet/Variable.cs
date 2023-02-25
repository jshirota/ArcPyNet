namespace ArcPyNet;

public record Variable
{
    public string Name { get; private set; } = default!;

    private string? json;
    public string Json => json ??= File.ReadAllText($@"{ArcPy.Instance.Workspace}\{this.Name}.json");

    public static implicit operator Variable(string name) => new() { Name = name };

    public override string ToString()
    {
        return this.Name;
    }
}

public interface IVariable
{
    public Variable Variable { get; }
}
