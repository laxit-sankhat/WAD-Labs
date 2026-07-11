int choice;
int n1, n2;

Console.WriteLine("1. Addition");
Console.WriteLine("2. Subtraction");
Console.WriteLine("3. Multiplication");
Console.WriteLine("4. Division");
Console.WriteLine("5. Modulus");

Console.Write("Enter your choice: ");
choice = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter first number: ");
n1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter second number: ");
n2 = Convert.ToInt32(Console.ReadLine());

switch (choice)
{
    case 1:
        Console.WriteLine("Result = " + (n1 + n2));
        break;

    case 2:
        Console.WriteLine("Result = " + (n1 - n2));
        break;

    case 3:
        Console.WriteLine("Result = " + (n1 * n2));
        break;

    case 4:
        if (n2 != 0)
        {
            Console.WriteLine("Result = " + (n1 / n2));
        }
        else
        {
            Console.WriteLine("Division by zero is not allowed.");
        }
        break;

    case 5:
        if (n2 != 0)
        {
            Console.WriteLine("Result = " + (n1 % n2));
        }
        else
        {
            Console.WriteLine("Modulus by zero is not allowed.");
        }
        break;

    default:
        Console.WriteLine("Invalid choice.");
        break;
}