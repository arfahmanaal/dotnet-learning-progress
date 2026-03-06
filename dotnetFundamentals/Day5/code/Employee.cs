namespace Day5Examples
{
   public class EmployeeDetails
    {
        public string Name;
        public int Id;

        public EmployeeDetails(string name, int id)
        {
            Name = name;
            Id = id;
        }
        public void ShowDetails()
        {
            Console.WriteLine($"Employee Name: {Name}, Id: {Id}");
        }
    }
        public static class Employee
    {
        public static void Run()
        {
            Console.WriteLine("Basic Employee Details");

            EmployeeDetails emp1 = new EmployeeDetails("Alice", 101);
            EmployeeDetails emp2 = new EmployeeDetails("Bob", 102);

            emp1.ShowDetails();
            emp2.ShowDetails();
        }
    }

}