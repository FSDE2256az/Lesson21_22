namespace _1.Linq.ExtentionMethods;

public static class CustomExtentions
{
    public static void Print(this IEnumerable<int> numbers)
    {
        foreach (var item in numbers)
        {
            Console.WriteLine(item);
        }
    }

    public static void PrintGeneric<T>(this IEnumerable<T> numbers)
    {
        foreach (var item in numbers)
        {
            Console.WriteLine(item);
        }
    }
}
