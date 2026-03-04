public static class Countdown
{
    public static void Run()
    {
        Console.WriteLine("While Loop: Countdown");
        Console.Write("Enter number for countdown: ");
        int count = int.Parse(Console.ReadLine()!);

        while (count > 0)
        {
            Console.WriteLine($"Countdown: {count}");
            count--;
        }
    }
}