using System.Text.Json;

namespace ArcPyNet;

public record Code
{
    public string Text { get; private set; } = default!;

    private string? json;

    public T GetValue<T>()
    {
        this.json ??= File.ReadAllText($@"{ArcPy.Instance.Workspace}\{this.Text}.json");

        var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
        var value = JsonSerializer.Deserialize<T>(this.json, options)!;

        return value;
    }

    public static implicit operator Code(string text) => new() { Text = text };
    public static implicit operator string(Code variable) => variable.Text;

    public override string ToString()
    {
        return this.Text;
    }
}

public interface IVariable
{
    public Code Variable { get; }
}
