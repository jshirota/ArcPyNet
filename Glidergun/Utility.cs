using System.ComponentModel;

namespace Glidergun;

internal static class Utility
{
    public static T FindEnum<T>(string name) where T : Enum
        => Enum.GetValues(typeof(T)).Cast<T>().Single(x => x.ToString().Equals(name, StringComparison.InvariantCultureIgnoreCase));

    public static string GetDescription<T>(this T @enum) where T : Enum
        => $"{typeof(T).GetMember(@enum.ToString()).Single().GetCustomAttributes(false).OfType<DescriptionAttribute>().Single().Description}";
}
