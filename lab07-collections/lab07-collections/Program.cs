using System;
using System.Collections.Generic;

namespace lab07_collections
{
    class Program
    {
        static void Main(string[] args)
        {
            Library<Book> Library = new Library<Book>();
            List<Book> BookBag = new List<Book>();

            bool menu = true;
            while (menu)
            {
                menu = UserInterface();
            }
        }

        static bool UserInterface()
        {
            Console.Clear();
            Console.WriteLine("Welcome to Hogwart's Mystery Library");
            Console.WriteLine("The books here are only available to wizards not to muggles!");
            Console.WriteLine("Please select one of the options from the menu.");
            Console.WriteLine("1) View all books");
            Console.WriteLine("2) Add a book");
            Console.WriteLine("3) Borrow a book");
            Console.WriteLine("4) Return a book");
            Console.WriteLine("5) View book bag");
            Console.WriteLine("6) Exit");
            string selection = Console.ReadLine();
            try
            {
                switch (selection)
                {
                    case "1":
                        ViewAllBooks();
                        Console.ReadLine();
                        return true;

                    case "2":
                        AddBooks();
                        Console.ReadLine();
                        return true;

                    case "3":
                        BorrowBooks();
                        return true;

                    case "4":
                        ReturnBooks();
                        return true;

                    case "5":
                        ViewBookBag();
                        Console.ReadLine();
                        return true;

                    case "6":
                        Console.WriteLine("Come back next time to learn more wizard tricks.");
                        Console.ReadLine();
                        return false;

                    default:
                        Console.WriteLine("Your selection is invalid.");
                        Console.ReadLine();
                        return true;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
