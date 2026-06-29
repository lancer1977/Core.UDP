using System;
using System.Text.Json;

namespace PolyhydraSoftware.Core.UDP;

public static class JsonExtensions
{
    public static string ToJson<T>(this T value)
    {
        return JsonSerializer.Serialize(value);
    }

    public static T FromJson<T>(this string json)
    {
        if (string.IsNullOrWhiteSpace(json))
        {
            return default!;
        }

        return JsonSerializer.Deserialize<T>(json)!;
    }
}
