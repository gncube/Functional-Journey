// C# 3

int[] array = { 3, 9, 5, 13, 12, 30 };
var query =
    array
        .Where(i => i > 5)
        .Where(i => i % 2 == 0);

foreach (int value in query) { Console.WriteLine(value); }

public delegate bool Predicate<T>(T t);