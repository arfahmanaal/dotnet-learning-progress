public static class NumberRange
{
    public static void Run()
    {
        Console.WriteLine("For Loop: Number Range ");
        Console.Write("Enter starting number: ");
        int start = int.Parse(Console.ReadLine()!);
        Console.Write("Enter ending number: ");
        int end = int.Parse(Console.ReadLine()!);

        for (int i = start; i <= end; i++)
        {
            Console.WriteLine($"Number: {i}");
        }
    }
}