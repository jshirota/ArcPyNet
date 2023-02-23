namespace ArcPy;

/// <summary>
/// Represents a Python variable.
/// </summary>
public class Variable
{
    private readonly string name;

    /// <summary>
    /// Initializes a new instance of the <see cref="Variable"/> class.
    /// </summary>
    /// <param name="name">The name of the variable.</param>
    public Variable(string name)
    {
        this.name = name;
    }

    /// <summary>
    /// Converts a string to a <see cref="Variable"/>.
    /// </summary>
    /// <param name="name"></param>
    public static implicit operator Variable(string name) => new(name);

    /// <summary>
    /// Converts a <see cref="Variable"/> to a string.
    /// </summary>
    /// <param name="variable"></param>
    public static implicit operator string(Variable variable) => variable.name;

    /// <summary>
    /// Returns the name of the variable.
    /// </summary>
    /// <returns>The name of the variable.</returns>
    public override string ToString()
    {
        return this.name;
    }
}
