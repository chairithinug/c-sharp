using System;

class LibraryManager
{
    static void Main()
    {
        string[] books = new string[5];
        bool[] isBorrowed = new bool[5];
        int borrowedCount = 0;

        while (true)
        {
            Console.WriteLine("\nLibrary Menu:");
            Console.WriteLine("1. Add a book");
            Console.WriteLine("2. Remove a book");
            Console.WriteLine("3. Search for a book");
            Console.WriteLine("4. Borrow a book");
            Console.WriteLine("5. Return a book");
            Console.WriteLine("6. Display books");
            Console.WriteLine("7. Exit");
            Console.Write("Choose an action: ");
            string action = Console.ReadLine()?.Trim();

            switch (action)
            {
                case "1":
                    ManageBook(books, isBorrowed, "add");
                    break;
                case "2":
                    ManageBook(books, isBorrowed, "remove");
                    break;
                case "3":
                    SearchBook(books);
                    break;
                case "4":
                    BorrowBook(books, isBorrowed, ref borrowedCount);
                    break;
                case "5":
                    ReturnBook(books, isBorrowed, ref borrowedCount);
                    break;
                case "6":
                    DisplayBooks(books, isBorrowed);
                    break;
                case "7":
                    Console.WriteLine("Exiting the library system. Goodbye!");
                    return;
                default:
                    Console.WriteLine("Invalid action. Please choose a valid option.");
                    break;
            }
        }
    }

    static void ManageBook(string[] books, bool[] isBorrowed, string action)
    {
        if (action == "add")
        {
            for (int i = 0; i < books.Length; i++)
            {
                if (string.IsNullOrEmpty(books[i]))
                {
                    Console.Write("Enter the title of the book to add: ");
                    string newBook = Console.ReadLine()?.Trim();

                    if (!string.IsNullOrEmpty(newBook))
                    {
                        books[i] = newBook;
                        Console.WriteLine($"Book '{newBook}' added.");
                    }
                    else
                    {
                        Console.WriteLine("Invalid book title. Please try again.");
                    }
                    return;
                }
            }
            Console.WriteLine("The library is full. No more books can be added.");
        }
        else if (action == "remove")
        {
            Console.Write("Enter the title of the book to remove: ");
            string removeBook = Console.ReadLine()?.Trim();

            if (string.IsNullOrEmpty(removeBook))
            {
                Console.WriteLine("Invalid book title. Please try again.");
                return;
            }

            for (int i = 0; i < books.Length; i++)
            {
                if (!string.IsNullOrEmpty(books[i]) && books[i].Equals(removeBook, StringComparison.OrdinalIgnoreCase))
                {
                    if (isBorrowed[i])
                    {
                        Console.WriteLine($"Cannot remove '{books[i]}' because it is currently borrowed.");
                        return;
                    }

                    Console.WriteLine($"Book '{books[i]}' removed.");
                    books[i] = null;
                    return;
                }
            }
            Console.WriteLine($"Book '{removeBook}' not found.");
        }
    }

    static void SearchBook(string[] books)
    {
        Console.Write("Enter the title of the book to search for: ");
        string searchBook = Console.ReadLine()?.Trim();

        foreach (string book in books)
        {
            if (!string.IsNullOrEmpty(book) && book.Equals(searchBook, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine($"Book '{searchBook}' is available in the library.");
                return;
            }
        }

        Console.WriteLine($"Book '{searchBook}' is not in the library.");
    }

    static void BorrowBook(string[] books, bool[] isBorrowed, ref int borrowedCount)
    {
        if (borrowedCount >= 3)
        {
            Console.WriteLine("You have reached the borrowing limit of 3 books.");
            return;
        }

        Console.Write("Enter the title of the book to borrow: ");
        string borrowBook = Console.ReadLine()?.Trim();

        for (int i = 0; i < books.Length; i++)
        {
            if (!string.IsNullOrEmpty(books[i]) && books[i].Equals(borrowBook, StringComparison.OrdinalIgnoreCase))
            {
                if (isBorrowed[i])
                {
                    Console.WriteLine($"Book '{books[i]}' is already borrowed.");
                    return;
                }

                isBorrowed[i] = true;
                borrowedCount++;
                Console.WriteLine($"You have borrowed '{books[i]}'.");
                return;
            }
        }

        Console.WriteLine($"Book '{borrowBook}' is not available in the library.");
    }

    static void ReturnBook(string[] books, bool[] isBorrowed, ref int borrowedCount)
    {
        Console.Write("Enter the title of the book to return: ");
        string returnBook = Console.ReadLine()?.Trim();

        for (int i = 0; i < books.Length; i++)
        {
            if (!string.IsNullOrEmpty(books[i]) && books[i].Equals(returnBook, StringComparison.OrdinalIgnoreCase))
            {
                if (!isBorrowed[i])
                {
                    Console.WriteLine($"Book '{books[i]}' was not borrowed.");
                    return;
                }

                isBorrowed[i] = false;
                borrowedCount--;
                Console.WriteLine($"You have returned '{books[i]}'.");
                return;
            }
        }

        Console.WriteLine($"Book '{returnBook}' is not in the library.");
    }

    static void DisplayBooks(string[] books, bool[] isBorrowed)
    {
        Console.WriteLine("\nAvailable books:");
        bool hasBooks = false;

        for (int i = 0; i < books.Length; i++)
        {
            if (!string.IsNullOrEmpty(books[i]))
            {
                string status = isBorrowed[i] ? "(Borrowed)" : "(Available)";
                Console.WriteLine($"- {books[i]} {status}");
                hasBooks = true;
            }
        }

        if (!hasBooks)
        {
            Console.WriteLine("No books in the library.");
        }
    }
}