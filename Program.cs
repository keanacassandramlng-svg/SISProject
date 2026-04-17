using SISProject.Services;

class Program
{
    static void Main()
    {
        var service = new StudentService();

        while (true)
        {
            Console.WriteLine("\n===== STUDENT INFORMATION SYSTEM =====");
            Console.WriteLine("1. Apply");
            Console.WriteLine("2. Enroll");
            Console.WriteLine("3. Deactivate");
            Console.WriteLine("4. Graduate");
            Console.WriteLine("5. Leave of Absence");
            Console.WriteLine("6. Show Student Info");
            Console.WriteLine("7. Exit");
            Console.Write("Choose: ");

            string choice = Console.ReadLine();

            if (choice == "1")
            {
                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Birthday: ");
                string birthday = Console.ReadLine();

                Console.Write("Address: ");
                string address = Console.ReadLine();

                Console.Write("Contact: ");
                string contact = Console.ReadLine();

                var student = service.Apply(name, birthday, address, contact);
                Console.WriteLine($"Application successful! Student Number: {student.StudentNumber}");
            }
            else if (choice == "2")
            {
                Console.Write("Student Number: ");
                string number = Console.ReadLine();

                Console.WriteLine(service.Enroll(number)
                    ? "Student enrolled successfully!"
                    : "Cannot enroll.");
            }
            else if (choice == "3")
            {
                Console.Write("Student Number: ");
                string number = Console.ReadLine();

                Console.WriteLine(service.Deactivate(number)
                    ? "Student deactivated."
                    : "Cannot deactivate.");
            }
            else if (choice == "4")
            {
                Console.Write("Student Number: ");
                string number = Console.ReadLine();

                Console.WriteLine(service.Graduate(number)
                    ? "Student graduated!"
                    : "Cannot graduate.");
            }
            else if (choice == "5")
            {
                Console.Write("Student Number: ");
                string number = Console.ReadLine();

                Console.WriteLine(service.LeaveOfAbsence(number)
                    ? "Student is on leave."
                    : "Cannot process leave.");
            }
            else if (choice == "6")
            {
                Console.Write("Student Number: ");
                string number = Console.ReadLine();

                var s = service.GetStudent(number);

                if (s != null)
                {
                    Console.WriteLine($"\nNumber: {s.StudentNumber}");
                    Console.WriteLine($"Name: {s.Name}");
                    Console.WriteLine($"Birthday: {s.Birthday}");
                    Console.WriteLine($"Address: {s.Address}");
                    Console.WriteLine($"Contact: {s.Contact}");
                    Console.WriteLine($"Status: {s.Status}");
                }
                else
                {
                    Console.WriteLine("Student not found.");
                }
            }
            else if (choice == "7")
            {
                break;
            }
            else
            {
                Console.WriteLine("Invalid choice.");
            }
        }
    }
}
