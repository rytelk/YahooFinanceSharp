using System.Text.Json;

namespace YahooFinanceSharp.Tests;

public static class JsonExtensions
{
    public static string SerializeToJson<T>(this T @this)
    {
        return JsonSerializer.Serialize(@this);
    }
}