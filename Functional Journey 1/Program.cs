// C# 2

int[] array = { 3, 9, 5, 13, 12, 30 };
var query = Filter<int>(array, GreaterThanFive);
foreach (int value in query) { Console.WriteLine(value); }
bool GreaterThanFive(int i) { return i > 5; }

IEnumerable<T> Filter<T>(IEnumerable<T> src, Predicate<T> p)
{
    List<T> dst = new List<T>();
    foreach (T value in src)
    { if (p(value)) yield return value; }
}

delegate bool Predicate<T>(T t);