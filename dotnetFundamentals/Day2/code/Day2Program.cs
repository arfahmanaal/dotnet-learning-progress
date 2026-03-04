namespace Day2Examples
{public static class Day2Program
{
public static void Run()
{

Console.WriteLine("VARIABLES:");
// Explicit variables
Console.Write("Enter a number: ");
int number = int.Parse(Console.ReadLine()!);
Console.Write("Enter a message: ");
string message = Console.ReadLine()!;
Console.Write("Enter Activity Status(True/False): ");
bool isActive = bool.Parse(Console.ReadLine()!);

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
double temperature = 36.6;
float discount = 5.5f;       
char grade = 'A';          
string course = "C# Basics"; 
bool passed = true;         

Console.WriteLine($"Count: {count}");
Console.WriteLine($"Price: {price}");
Console.WriteLine($"Temperature: {temperature}");
Console.WriteLine($"Discount: {discount}");
Console.WriteLine($"Grade: {grade}");
Console.WriteLine($"Course: {course}");
Console.WriteLine($"Passed: {passed}");

Console.WriteLine("");
Console.WriteLine("OPERATORS:");
Console.Write("Enter first number: ");
int a = int.Parse(Console.ReadLine()!);
Console.Write("Enter second number: ");
int b = int.Parse(Console.ReadLine()!);
// Arithmetic
Console.WriteLine($"Addition: {a + b}");
Console.WriteLine($"Subtraction: {a - b}");
Console.WriteLine($"Multiplication: {a * b}");
Console.WriteLine($"Division: {a / b}");
Console.WriteLine($"Remainder: {a % b}");

// Type conversion
double d = (double)a / b;
Console.WriteLine($"Division (floating-point): {d}");

// Comparison
Console.WriteLine($"Is a greater than b? {a > b}");
Console.WriteLine($"Is a equal to b? {a == b}");
Console.WriteLine($"Is a less than or equal to b? {a <= b}");

// Logical
bool condition1 = (a > b) && (b > 0); 
bool condition2 = (a > b) || (b > 10); 
bool condition3 = !(a < b); 
Console.WriteLine($"(a > b) AND (b > 0): {condition1}");
Console.WriteLine($"(a > b) OR (b > 10): {condition2}");
Console.WriteLine($"NOT (a < b): {condition3}");
}
}
}