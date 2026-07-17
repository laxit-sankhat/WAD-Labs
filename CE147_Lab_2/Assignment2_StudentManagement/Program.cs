List<string> studentNames = new List<string>();

int choice;

do
{
    Console.WriteLine("\n===== Student Management System =====");
    Console.WriteLine("1. Add Student");
    Console.WriteLine("2. Display All Students");
    Console.WriteLine("3. Search Student");
    Console.WriteLine("4. Update Student");
    Console.WriteLine("5. Delete Student");
    Console.WriteLine("6. Exit");
    Console.Write("Enter your choice: ");

    choice = int.Parse(Console.ReadLine());

    switch (choice)
    {
        case 1:
            Console.Write("Enter student name: ");
            string name = Console.ReadLine();

            studentNames.Add(name);

            Console.WriteLine("Student added successfully.");
            break;

        case 2:
            if (studentNames.Count == 0)
            {
                Console.WriteLine("No students found.");
            }
            else
            {
                Console.WriteLine("\nList of Students:");

                int number = 1;

                foreach (string student in studentNames)
                {
                    Console.WriteLine(number + ". " + student);
                    number++;
                }
            }
            break;

        case 3:
            Console.Write("Enter student name to search: ");
            string searchName = Console.ReadLine();

            int searchIndex = studentNames.IndexOf(searchName);

            if (searchIndex == -1)
            {
                Console.WriteLine("Student not found.");
            }
            else
            {
                Console.WriteLine(
                    "Student found at position: " + (searchIndex + 1)
                );
            }
            break;

        case 4:
            Console.Write("Enter student name to update: ");
            string updateName = Console.ReadLine();

            int updateIndex = studentNames.IndexOf(updateName);

            if (updateIndex != -1)
            {
                Console.Write("Enter new name: ");
                string newName = Console.ReadLine();

                studentNames[updateIndex] = newName;

                Console.WriteLine("Student updated successfully.");
            }
            else
            {
                Console.WriteLine("Student not found.");
            }
            break;

        case 5:
            Console.Write("Enter student name to delete: ");
            string deleteName = Console.ReadLine();

            int deleteIndex = studentNames.IndexOf(deleteName);

            if (deleteIndex != -1)
            {
                studentNames.RemoveAt(deleteIndex);

                Console.WriteLine("Student deleted successfully.");
            }
            else
            {
                Console.WriteLine("Student not found.");
            }
            break;

        case 6:
            Console.WriteLine("Exiting application...");
            break;

        default:
            Console.WriteLine(
                "Invalid choice. Enter a number from 1 to 6."
            );
            break;
    }

} while (choice != 6);