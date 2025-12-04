using Week1_OOP_Exercise.BankModule;
using Week1_OOP_Exercise.ShapeModule;
using Week1_OOP_Exercise.StudentModule;

namespace Week1_OOP_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            StudentManager studentManager = new StudentManager();
            BankAccount account = new BankAccount("Yolo", 1000); // Bank account exercise

            int choice;

            do
            {
                Console.WriteLine("\n Main Menu ");
                Console.WriteLine("1. Student Manager");
                Console.WriteLine("2. Bank Account");
                Console.WriteLine("3. Shapes Demo");
                Console.WriteLine("0. Exit");
                Console.Write("Select option: ");

                int.TryParse(Console.ReadLine(), out choice);

                switch (choice)
                {
                    case 1:
                        ShowStudentMenu(studentManager);
                        break;

                    case 2:
                        ShowBankMenu(account);
                        break;

                    case 3:
                        ShowShapesDemo();
                        break;
                }

            } while (choice != 0);
        }

        // The Student menu
        static void ShowStudentMenu(StudentManager manager)
        {
            int option;

            do
            {
                Console.WriteLine("\n Student Manager ");
                Console.WriteLine("1. Add Student");
                Console.WriteLine("2. Remove Student");
                Console.WriteLine("3. List Students");
                Console.WriteLine("0. Back");
                Console.Write("Choose: ");

                int.TryParse(Console.ReadLine(), out option);

                switch (option)
                {
                    case 1:
                        Console.Write("Enter ID: ");
                        int id = int.Parse(Console.ReadLine());
                        Console.Write("Enter Name: ");
                        string name = Console.ReadLine();

                        manager.AddStudent(new Student(id, name));
                        break;

                    case 2:
                        Console.Write("Enter ID to remove: ");
                        int removeId = int.Parse(Console.ReadLine());
                        manager.RemoveStudent(removeId);
                        break;

                    case 3:
                        manager.ListStudents();
                        break;
                }

            } while (option != 0);
        }

        // The Bank menu
        static void ShowBankMenu(BankAccount account)
        {
            int option;

            do
            {
                Console.WriteLine("\n--- Bank Account ---");
                Console.WriteLine("1. Deposit");
                Console.WriteLine("2. Withdraw");
                Console.WriteLine("3. Show Balance");
                Console.WriteLine("0. Back");
                Console.Write("Choose: ");

                int.TryParse(Console.ReadLine(), out option);

                switch (option)
                {
                    case 1:
                        Console.Write("Enter amount: ");
                        account.Deposit(decimal.Parse(Console.ReadLine()));
                        break;

                    case 2:
                        Console.Write("Enter amount: ");
                        account.Withdraw(decimal.Parse(Console.ReadLine()));
                        break;

                    case 3:
                        Console.WriteLine($"Current Balance: R{account.Balance}");
                        break;
                }

            } while (option != 0);
        }

        // The Shapes demo
        static void ShowShapesDemo()
        {
            Console.WriteLine("\n--- Shapes Demo ---");

            IShape circle = new Circle(4);
            IShape rectangle = new Rectangle(5, 10);

            Console.WriteLine($"Circle Area (r=4): {circle.CalculateArea()}");
            Console.WriteLine($"Rectangle Area (5x10): {rectangle.CalculateArea()}");
        }
    }
}

