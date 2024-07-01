namespace ConsoleApp3;

public class QueryMethods
{
    public static string[] GetBasic(string[] words)
    {
        return words
            .Where(w => w.Length > 5)
            .Distinct()
            .ToArray();
    }
    
    public static string[] GetOrdered(string[] words)
    {
        return words
            .OrderByDescending(w => w)
            .ToArray();
    }
    
    public static string[] GetFewer(string[] words)
    {
        return words
            .Take(10)
            .OrderByDescending(w => w)
            .ToArray();
    }

    public static string[] GetReverse(string[] words)
    {
        return words
            .Take(10)
            .Reverse()
            .ToArray();
    }
    
    public static string[] GetOdd(string[] words, string[] words2)
    {
        return words
            .Except(words2)
            .ToArray();
    }

}