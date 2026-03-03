using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("VARIABLES:");
        // Explicit variables
        int number = 10;
        string message = "Hello, C#";
        bool isActive = true;

        // Implicit variable 
        var progress = "Day 2 Learning Progress"; 

        Console.WriteLine($"Number: {number}");
        Console.WriteLine($"Message: {message}");
        Console.WriteLine($"Is Active: {isActive}");
        Console.WriteLine($"Progress: {progress}");

        Console.WriteLine("");
        Console.WriteLine("DATA TYPES:");
        int count = 10;            
        decimal price = 99.98M;       
        char grade = 'A';          
        string course = "C# Basics"; 
        bool passed = true;         

        Console.WriteLine($"Count: {count}");
        Console.WriteLine($"Price: {price}");
        Console.WriteLine($"Grade: {grade}");
        Console.WriteLine($"Course: {course}");
        Console.WriteLine($"Passed: {passed}");

        Console.WriteLine("");
        Console.WriteLine("OPERATORS:");
        int a = 15, b = 4;
        // Arithmetic
        Console.WriteLine($"Addition: {a + b}");
        Console.WriteLine($"Subtraction: {a - b}");
        Console.WriteLine($"Multiplication: {a * b}");
        Console.WriteLine($"Division: {a / b}");
        Console.WriteLine($"Remainder: {a % b}");

        // Comparison
        Console.WriteLine($"Is a greater than b? {a > b}");
        Console.WriteLine($"Is a equal to b? {a == b}");

        // Logical
        bool condition = (a > b) && (b > 0);
        Console.WriteLine($"Condition result: {condition}");
    

    }
}