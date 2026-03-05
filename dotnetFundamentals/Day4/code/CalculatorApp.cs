namespace Day4Example
{
    public static class CalculatorApp
    {
        public static void Run()
        {
            bool isRunning = true;

            while (isRunning)
            {
                ShowMenu();

                Console.Write("Select an option: ");
                string? choice = Console.ReadLine();

               if (choice == null || choice != "1" && choice != "2" && choice != "3" && choice != "4" && choice != "5")
                {
                    Console.WriteLine("Invalid option. Please enter 1-5.");
                    Console.WriteLine("Press Enter to continue...");
                    Console.ReadLine();
                    continue; 
                }

                if (choice == "5")
                {
                    Console.WriteLine("Exiting calculator...");
                    isRunning = false;
                    continue;
                }

                try
                {
                    double num1 = ReadNumber("Enter first number: ");
                    double num2 = ReadNumber("Enter second number: ");

                    double result = PerformCalculation(choice, num1, num2);

                    Console.WriteLine("Result: " + result);
                }
                catch (DivideByZeroException)
                {
                    Console.WriteLine("Cannot divide by zero.");
                }
                catch (Exception)
                {
                    Console.WriteLine("Invalid option selected.");
                }

                Console.WriteLine();
                Console.WriteLine("Press Enter to continue...");
                Console.ReadLine();
            }
        }

        private static void ShowMenu()
        {
            Console.Clear();
            Console.WriteLine("CALCULATOR APP");
            Console.WriteLine("1. Add");
            Console.WriteLine("2. Subtract");
            Console.WriteLine("3. Multiply");
            Console.WriteLine("4. Divide");
            Console.WriteLine("5. Exit");
            Console.WriteLine();
        }

        private static double ReadNumber(string message)
        {
            double number;

            while (true)
            {
                Console.Write(message);
                string? input = Console.ReadLine();

                if (double.TryParse(input, out number))
                {
                    return number;
                }

                Console.WriteLine("Enter valid number.");
            }
        }

        private static double PerformCalculation(string choice, double a, double b)
        {
            switch (choice)
            {
                case "1":
                    return Add(a, b);

                case "2":
                    return Subtract(a, b);

                case "3":
                    return Multiply(a, b);

                case "4":
                    return Divide(a, b);

                default:
                    throw new Exception("Invalid option");
            }
        }

        private static double Add(double a, double b)
        {
            return a + b;
        }

        private static double Subtract(double a, double b)
        {
            return a - b;
        }

        private static double Multiply(double a, double b)
        {
            return a * b;
        }

        private static double Divide(double a, double b)
        {
            if (b == 0)
            {
                throw new DivideByZeroException();
            }

            return a / b;
        }
    }
}