namespace Glidergun;

public class FilePath
{
    private readonly string path;

    public FilePath(string name)
    {
        path = Path.IsPathRooted(name) ? name
            : Path.Combine(Environment.CurrentDirectory, name);
    }

    public static implicit operator FilePath(string path) => new(path);
    public static implicit operator string(FilePath path) => path.path;

    public override string ToString() => path;
}
