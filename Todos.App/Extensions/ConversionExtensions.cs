namespace Todos.App.Extensions;

public static class ConversionExtensions
{
    public static bool Tobool(this object? Value) => Value is not null && (bool)Value;
}
