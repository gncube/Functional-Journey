public static class Extensions
{
    public static IEnumerable<T> Where<T>(this IEnumerable<T> src, Predicate<T> p)
    {
        foreach (T value in src)
        { if (p(value)) yield return value; }
    }
}