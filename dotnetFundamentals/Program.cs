// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using Day3Examples;
using Day2Examples;
using Day4Example;
using Day5Examples;
using Day6Example;
class Program
{
    static void Main()
    {
        Console.WriteLine("");

        //Day2Program.Run();
        //Day3Program.Run();
        //CalculatorApp.Run();
        //Day5Programs.Run();
        var emp = new EmployeeRunner();
        emp.Run();
    }
}
