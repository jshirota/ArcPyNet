using System.Text.Json;

namespace ArcPyNet;

public record Code
{
    public string Text { get; private set; } = default!;

    private string? json;

    public T Evaluate<T>()
    {
        if (this.json is null)
        {
            var temp = ArcPy.GetTempName();
            var jsonPath = $@"{ArcPy.Instance.Workspace}\{temp}.json";

            ArcPy.Instance.Run($"""
                with open(r"{jsonPath}", "w") as json_file:
                    json_file.write(json.dumps({Text}, default=str))
                """, "None");

            this.json = File.ReadAllText(jsonPath);
        }

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
