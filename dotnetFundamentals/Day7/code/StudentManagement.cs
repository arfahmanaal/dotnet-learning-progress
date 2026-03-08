namespace week1Assessment
{
    class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Grade { get; set; }

        public Student(int id, string name, int age, string grade)
        {
            Id = id;
            Name = name;
            Age = age;
            Grade = grade;
        }

        public void Display()
        {
            Console.WriteLine($"ID: {Id} | Name: {Name} | Age: {Age} | Grade: {Grade}");
        }
    }

    class StudentManagement
    {
        private Student[] students = new Student[100];
        private int count = 0;
        private int nextId = 1;

        public void AddStudent()
        {
            Console.Write("Name: ");
            string name = Console.ReadLine()!;
            Console.Write("Age: ");
            int age = int.Parse(Console.ReadLine()!);
            Console.Write("Grade: ");
            string grade = Console.ReadLine()!;

            students[count] = new Student(nextId, name, age, grade);
            count++;
            nextId++;
            Console.WriteLine("Student added successfully.");
        }

        public void ViewStudents()
        {
            if (count == 0)
            {
                Console.WriteLine("No students found.");
                return;
            }
            for (int i = 0; i < count; i++)
            {
                students[i].Display();
            }
        }

        public void UpdateStudent()
{
    if (count == 0)
    {
        Console.WriteLine("No students available to update.");
        return;
    }

    Console.Write("Enter ID to update: ");
    int id = int.Parse(Console.ReadLine()!);

    for (int i = 0; i < count; i++)
    {
        if (students[i].Id == id)
        {
            Console.WriteLine("Press Enter to keep existing value.\n");

            Console.Write($"Enter Updated Name ({students[i].Name}): ");
            string name = Console.ReadLine()!;
            if (!string.IsNullOrWhiteSpace(name))
                students[i].Name = name;

            Console.Write($"Enter Updated Age ({students[i].Age}): ");
            string ageInput = Console.ReadLine()!;
            if (!string.IsNullOrWhiteSpace(ageInput))
                students[i].Age = int.Parse(ageInput);

            Console.Write($"Enter Updated Grade ({students[i].Grade}): ");
            string grade = Console.ReadLine()!;
            if (!string.IsNullOrWhiteSpace(grade))
                students[i].Grade = grade;

            Console.WriteLine("Student updated successfully.");
            return;
        }
    }

    Console.WriteLine("Student not found.");
}

        public void DeleteStudent()
        {
            if (count == 0)
            {
                Console.WriteLine("No students available to delete.");
            return;
            }
            Console.Write("Enter ID to delete: ");
            int id = int.Parse(Console.ReadLine( )!);

            for (int i = 0; i < count; i++)
            {
                if (students[i].Id == id)
                {
                    for (int j = i; j < count - 1; j++)
                    {
                        students[j] = students[j + 1];
                    }
                    students[count - 1] = null!;
                    count--;
                    Console.WriteLine("Student deleted successfully.");
                    return;
                }
            }
            Console.WriteLine("Student not found.");
        }

        public void Run()
        {
            bool running = true;
            while (running)
            {
                Console.WriteLine("\nSTUDENT MANAGEMENT SYSTEM");
                Console.WriteLine("1. Add Student");
                Console.WriteLine("2. View All Students");
                Console.WriteLine("3. Update Student");
                Console.WriteLine("4. Delete Student");
                Console.WriteLine("5. Exit");
                Console.Write("Choose: ");

                string choice = Console.ReadLine()!;

                switch (choice)
                {
                    case "1":
                        AddStudent();
                        break;
                    case "2":
                        ViewStudents();
                        break;
                    case "3":
                        UpdateStudent();
                        break;
                    case "4":
                        DeleteStudent();
                        break;
                    case "5":
                        Console.WriteLine("Exit successful!");
                        return;
                    default:
                        Console.WriteLine("Invalid choice.");
                        break;
                }
                Console.Write("\nDo you want to continue? (Y/N): ");
                string response = Console.ReadLine()!.ToLower();

                if (response != "y")
                {
                    running = false;
                    Console.WriteLine("Exit successful!");
                }
            }
        }
    }
}