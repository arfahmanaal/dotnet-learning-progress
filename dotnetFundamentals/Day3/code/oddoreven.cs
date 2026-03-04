public static class OddOrEven
{
    public static void Run()
    {
        Console.WriteLine("If/Else: Odd or Even ");
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine()!);

        if (number % 2 == 0)
            Console.WriteLine($"{number} is Even");
        else
            Console.WriteLine($"{number} is Odd");
    }
}