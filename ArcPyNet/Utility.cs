using System.ComponentModel;

namespace ArcPyNet;

public static class Utility
{
    internal static string ToEnumString<T>(this T @enum) where T : Enum
    {
        var attribute = @enum
            .GetType()
            .GetMember(@enum.ToString())
            .Single()
            .GetCustomAttributes(false)
            .OfType<DescriptionAttribute>()
            .SingleOrDefault();

        if (attribute is null)
            return @enum.ToString();

        return attribute.Description;
    }
}
