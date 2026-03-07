namespace Day6Example
{
    public interface IPayable
    {
        decimal GetMonthlySalary();
    }

    public abstract class Employee
    {
        private string _name;
        private decimal _salary;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public decimal Salary
        {
            get { return _salary; }
            protected set { _salary = value; }
        }

        public string Department { get; set; }

        protected Employee(string name, string department, decimal salary)
        {
            _name = name;
            Department = department;
            _salary = salary;
        }

        public abstract string GetRole();

        public virtual void ShowInfo()
        {
            Console.WriteLine($"Name: {Name} | Role: {GetRole()} | Dept: {Department} | Salary: {Salary}");
        }
    }

    public class FullTimeEmployee : Employee, IPayable
    {
        public FullTimeEmployee(string name, string department, decimal salary)
            : base(name, department, salary)
        {
        }

        public override string GetRole() => "Full-Time Employee";

        public decimal GetMonthlySalary() => Salary / 12;
    }

    public class Manager : FullTimeEmployee
    {
        public Manager(string name, string department, decimal salary)
            : base(name, department, salary)
        {
        }

        public override string GetRole() => "Manager";
    }
    public class EmployeeRunner
    {
        public void Run()
        {
            var emp1 = new FullTimeEmployee("Alice", "Engineering", 720000);
            var emp2 = new FullTimeEmployee("Bob", "Design", 600000);
            var mgr  = new Manager("John", "Engineering", 1200000);

            Console.WriteLine("Encapsulation Example:");
            Console.WriteLine($"Name: {emp1.Name}");
            Console.WriteLine($"Salary: {emp1.Salary}");

            Console.WriteLine("\nInheritance Example: ");
            emp1.ShowInfo();
            emp2.ShowInfo();
            mgr.ShowInfo();

            Console.WriteLine("\nPolymorphism Example");
            Employee e = mgr;
            e.ShowInfo();

            Console.WriteLine("\nInterface Example ");
            IPayable p = emp1;
            Console.WriteLine($"{emp1.Name}: {p.GetMonthlySalary()}/month");
        }
    }
}