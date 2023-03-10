using System.Text.Json;

namespace ArcPyNet;

public record Code
{
    private readonly string expression;

    private string? json;

    private Code(string expression)
    {
        this.expression = expression;
    }

    public T Evaluate<T>()
    {
        if (this.json is null)
        {
            var temp = ArcPy.GetTempName();
            var jsonPath = $@"{ArcPy.Instance.Workspace}\{temp}.json";

            ArcPy.Instance.Run($"""
                with open(r"{jsonPath}", "w") as json_file:
                    json_file.write(json.dumps({expression}, default=str))
                """, "None");

            this.json = File.ReadAllText(jsonPath);
        }

        var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
        var value = JsonSerializer.Deserialize<T>(this.json, options)!;

        return value;
    }

    public static implicit operator Code(string expression) => new(expression);
    public static implicit operator string(Code code) => code.expression;

    public override string ToString()
    {
        return this.expression;
    }
}
