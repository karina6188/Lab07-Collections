using System;
using System.Collections.Generic;

namespace lab07_collections
{
    class Program
    {
        static void Main(string[] args)
        {
            LoadBooks();
            bool menu = true;
            while (menu)
            {
                menu = UserInterface();
            }
        }

        public static Library<Book> HogwartLibrary = new Library<Book>();
        public static List<Book> BookBag = new List<Book>();
        public static Genre bookGenre = new Genre();

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
                        Console.WriteLine("Please enter information below for the book you want to add into the library.");
                        Console.WriteLine("Title of the book: ");
                        string title = Console.ReadLine();
                        Console.WriteLine("\nAuthor's first name: ");
                        string firstName = Console.ReadLine();
                        Console.WriteLine("\nAuthor's last name: ");
                        string lastName = Console.ReadLine();
                        Console.WriteLine("\n");
                        bool addBook = true;
                        while (addBook)
                        {
                            addBook = AddBooks(title, firstName, lastName);
                        }
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
                return false;
            }
        }

        public static void LoadBooks()
        {
            Author author1 = new Author("Rolanda", "Hooch");
            Book book1 = new Book("Flying to The Moon", author1, Genre.Motion);

            Author author2 = new Author("Albus", "Dumbledore");
            Book book2 = new Book("To Be Who? All You Need To Know About Transfiguration", author2, Genre.Transfiguration);

            Author author3 = new Author("Gilderoy", "Lockhart");
            Book book3 = new Book("Defence Against the Dark Arts", author3, Genre.DarkMagic);

            Author author4 = new Author("Quirnus", "Quirrell");
            Book book4 = new Book("Muggles and Wizards Development History", author4, Genre.MuggleStudies);

            Author author5 = new Author("Severus", "Snape");
            Book book5 = new Book("Potions: 1 Drip 2 Spells", author5, Genre.Potions);
            Book[] OriginalBooks = new Book[] { book1, book2, book3, book4, book5 };
            foreach (Book book in OriginalBooks)
            {
                HogwartLibrary.Add(book);
            }
        }

        public static void ViewAllBooks()
        {
            foreach (Book book in HogwartLibrary)
            {
                Console.WriteLine($"{book.Title} | Author: {book.Author.FirstName} {book.Author.LastName} | Genre: {book.Genre}");
            }
        }

        static bool AddBooks(string title, string firstName, string lastName)
        {
            Console.WriteLine("Choose a genre for the book: ");
            Console.WriteLine("1) Motion");
            Console.WriteLine("2) Transfiguration");
            Console.WriteLine("3) Dark Magic");
            Console.WriteLine("4) Muggle Studies");
            Console.WriteLine("5) Potions");
            Console.WriteLine("6) Ancient Runes");
            Console.WriteLine("7) History Of Magic");
            Console.WriteLine("8) Charm");
            Console.WriteLine("9) Care Of Magical Creatures");
            Console.WriteLine("10) Others");
            string chooseGenre = Console.ReadLine();
            switch (chooseGenre)
            {
                case "1":
                    Author author = new Author(firstName, lastName);
                    Book book = new Book(title, author, Genre.Motion);
                    HogwartLibrary.Add(book);
                    return false;
                case "2":
                    Author author2 = new Author(firstName, lastName);
                    Book book2 = new Book(title, author2, Genre.Transfiguration);
                    HogwartLibrary.Add(book2);
                    return false;
                case "3":
                    Author author3 = new Author(firstName, lastName);
                    Book book3 = new Book(title, author3, Genre.DarkMagic);
                    HogwartLibrary.Add(book3);
                    return false;
                case "4":
                    Author author4 = new Author(firstName, lastName);
                    Book book4 = new Book(title, author4, Genre.MuggleStudies);
                    HogwartLibrary.Add(book4);
                    return false;
                case "5":
                    Author author5 = new Author(firstName, lastName);
                    Book book5 = new Book(title, author5, Genre.Potions);
                    HogwartLibrary.Add(book5);
                    return false;
                case "6":
                    Author author6 = new Author(firstName, lastName);
                    Book book6 = new Book(title, author6, Genre.AncientRunes);
                    HogwartLibrary.Add(book6);
                    return false;
                case "7":
                    Author author7 = new Author(firstName, lastName);
                    Book book7 = new Book(title, author7, Genre.HistoryOfMagic);
                    HogwartLibrary.Add(book7);
                    return false;
                case "8":
                    Author author8= new Author(firstName, lastName);
                    Book book8 = new Book(title, author8, Genre.Charm);
                    HogwartLibrary.Add(book8);
                    return false;
                case "9":
                    Author author9 = new Author(firstName, lastName);
                    Book book9 = new Book(title, author9, Genre.CareOfMagicalCreatures);
                    HogwartLibrary.Add(book9);
                    return false;
                case "10":
                    Author author10 = new Author(firstName, lastName);
                    Book book10 = new Book(title, author10, Genre.Others);
                    HogwartLibrary.Add(book10);
                    return false;
                default:
                    Console.WriteLine("Please enter a valid selection.");
                    return true;
            }
        }

        static void BorrowBooks()
        {

        }

        static void ReturnBooks()
        {

        }

        static void ViewBookBag()
        {

        }
    }
}
