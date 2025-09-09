using System;

class Program
{
    static void Main(string[] args)
    {
        // Initialize book storage with 5 empty slots
        string[] books = new string[5];

        while (true)
        {
            Console.WriteLine("\nLibrary Menu:");
            Console.WriteLine("1. Add a book");
            Console.WriteLine("2. Remove a book");
            Console.WriteLine("3. Display books");
            Console.WriteLine("4. Exit");
            Console.Write("Choose an action: ");
            string action = Console.ReadLine();

            if (action == "1") // Add a book
            {
                Console.Write("Enter the title of the book to add: ");
                string newBook = Console.ReadLine();

                bool added = false;
                for (int i = 0; i < books.Length; i++)
                {
                    if (string.IsNullOrEmpty(books[i]))
                    {
                        books[i] = newBook;
                        Console.WriteLine($"Book '{newBook}' added.");
                        added = true;
                        break;
                    }
                }

                if (!added)
                {
                    Console.WriteLine("Library is full. Cannot add more books.");
                }
            }
            else if (action == "2") // Remove a book
            {
                Console.Write("Enter the title of the book to remove: ");
                string bookToRemove = Console.ReadLine();

                bool removed = false;
                for (int i = 0; i < books.Length; i++)
                {
                    if (books[i] == bookToRemove)
                    {
                        books[i] = null;
                        Console.WriteLine($"Book '{bookToRemove}' removed.");
                        removed = true;
                        break;
                    }
                }

                if (!removed)
                {
                    Console.WriteLine($"Book '{bookToRemove}' not found.");
                }
            }
            else if (action == "3") // Display books
            {
                Console.WriteLine("Books in the library:");
                bool hasBooks = false;
                for (int i = 0; i < books.Length; i++)
                {
                    if (!string.IsNullOrEmpty(books[i]))
                    {
                        Console.WriteLine($"- {books[i]}");
                        hasBooks = true;
                    }
                }

                if (!hasBooks)
                {
                    Console.WriteLine("No books in the library.");
                }
            }
            else if (action == "4") // Exit
            {
                Console.WriteLine("Exiting the library system. Goodbye!");
                break;
            }
            else // Invalid action
            {
                Console.WriteLine("Invalid action. Please choose a valid option.");
            }
        }
    }
}