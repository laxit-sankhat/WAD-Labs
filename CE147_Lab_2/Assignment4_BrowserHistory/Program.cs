using System;
using System.Collections.Generic;

Stack<string> browserHistory = new Stack<string>();

int choice;

do
{
    Console.WriteLine("\n===== Browser History Menu =====");
    Console.WriteLine("1. Visit New Webpage");
    Console.WriteLine("2. Go Back");
    Console.WriteLine("3. View Current Page");
    Console.WriteLine("4. Display Browsing History");
    Console.WriteLine("5. Exit");
    Console.Write("Enter your choice: ");

    choice = int.Parse(Console.ReadLine());

    switch (choice)
    {
        case 1:
            Console.Write("Enter webpage URL: ");
            string webpage = Console.ReadLine();

            browserHistory.Push(webpage);

            Console.WriteLine("Webpage visited successfully.");
            break;

        case 2:
            if (browserHistory.Count > 1)
            {
                browserHistory.Pop();

                Console.WriteLine(
                    "Current page: " + browserHistory.Peek()
                );
            }
            else if (browserHistory.Count == 1)
            {
                Console.WriteLine("No previous page available.");
            }
            else
            {
                Console.WriteLine("Browsing history is empty.");
            }
            break;

        case 3:
            if (browserHistory.Count > 0)
            {
                Console.WriteLine(
                    "Current page: " + browserHistory.Peek()
                );
            }
            else
            {
                Console.WriteLine("No webpage is currently open.");
            }
            break;

        case 4:
            if (browserHistory.Count == 0)
            {
                Console.WriteLine("Browsing history is empty.");
            }
            else
            {
                Console.WriteLine("\nBrowsing History:");

                foreach (string page in browserHistory)
                {
                    Console.WriteLine(page);
                }
            }
            break;

        case 5:
            Console.WriteLine("Exiting application...");
            break;

        default:
            Console.WriteLine(
                "Invalid choice. Enter a number from 1 to 5."
            );
            break;
    }

} while (choice != 5);