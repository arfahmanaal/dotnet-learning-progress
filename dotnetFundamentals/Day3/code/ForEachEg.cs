public static class ForeachEg
{
    public static void Run()
    {
        Console.WriteLine("Foreach Loop: Programming Languages");
        Console.Write("Enter number of programming languages: ");
        int n = int.Parse(Console.ReadLine()!);

        string[] lang = new string[n];
        for (int i = 0; i < n; i++)
        {
            Console.Write($"Enter lang {i + 1}: ");
            lang[i] = Console.ReadLine()!;
        }

        Console.WriteLine("You entered:");
        foreach (string language in lang)
        {
            Console.WriteLine(language);
        }
    }
}