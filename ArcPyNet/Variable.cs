namespace ArcPyNet;

public class Variable
{
    private readonly string name;

    public Variable(string name)
    {
        this.name = name;
    }

    public static implicit operator string(Variable variable) => variable.name;
    public static implicit operator Variable(string name) => new(name);

    public override string ToString()
    {
        return this.name;
    }
}
