﻿using System;
using System.Collections.Generic;

namespace lab07_collections
{
    public class Program
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

        public static Library<Book> HogwartsLibrary = new Library<Book>();
        public static List<Book> BookBag = new List<Book>();
        public static Genre bookGenre = new Genre();

        #region UserInterface()
        /// <summary>
        /// List out the menu for the user to select.
        /// Keep displaying the menu until one of the selections are made or exit.
        /// </summary>
        /// <returns></returns>
        static bool UserInterface()
        {
            Console.Clear();
            Console.WriteLine("Welcome to Hogwarts' Mystery Library");
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
                        int totalBooks = HogwartsLibrary.Count();
                        Console.WriteLine($"========= There are {totalBooks} books in the library =========");
                        ViewAllBooks();
                        Console.ReadLine();
                        return true;

                    case "2":
                        Console.WriteLine("Please enter information below for the book you want to add into the library.");
                        while (true)
                        {
                            Console.WriteLine("Title of the book: ");
                            string title = Console.ReadLine();
                            Console.WriteLine("\nAuthor's first name: ");
                            string firstName = Console.ReadLine();
                            Console.WriteLine("\nAuthor's last name: ");
                            string lastName = Console.ReadLine();
                            Console.WriteLine("");
                            if (title.Length <= 0 || firstName.Length <= 0 || lastName.Length <= 0)
                            {
                                if (title.Length <= 0) Console.WriteLine("Your book title is empty. Please try again.");
                                if (firstName.Length <= 0) Console.WriteLine("Your author's first name is empty. Please try again.");
                                if (lastName.Length <= 0) Console.WriteLine("Your author's last name is empty. Please try again.");
                                Console.WriteLine();
                            }
                            else
                            {
                                bool addBook = true;
                                while (addBook)
                                {
                                    addBook = AddBooks(title, firstName, lastName);
                                }
                                break;
                            }
                        }
                        Console.WriteLine("The book has been added into the library.");
                        return true;

                    case "3":
                        Console.WriteLine("Please enter title of the book that you want to borrow:");
                        ViewAllBooks();
                        string bookBorrowed = Console.ReadLine();
                        BorrowBooks(bookBorrowed);
                        return true;

                    case "4":
                        ReturnBooks();
                        return true;

                    case "5":
                        int totalBooksInBag = ViewBookBag();
                        Console.WriteLine("");
                        Console.WriteLine($"There are {totalBooksInBag} books in your book bag.");
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
        #endregion

        #region LoadBooks()
        /// <summary>
        /// Create object instances of Book and create Author instances to construct author's first and last name.
        /// Add all the books into a Book array.
        /// User foreach to loop through all the books in the Book array and add into HogwartsLibrary.
        /// </summary>
        public static void LoadBooks()
        {
            Author author1 = new Author("Rolanda", "Hooch");
            Book book1 = new Book("Flying to The Moon", author1, Genre.Motion);

            Author author2 = new Author("Albus", "Dumbledore");
            Book book2 = new Book("All You Need To Know About Transfiguration", author2, Genre.Transfiguration);

            Author author3 = new Author("Gilderoy", "Lockhart");
            Book book3 = new Book("Defence Against the Dark Arts", author3, Genre.DarkMagic);

            Author author4 = new Author("Quirnus", "Quirrell");
            Book book4 = new Book("Muggles and Wizards Development History", author4, Genre.MuggleStudies);

            Author author5 = new Author("Severus", "Snape");
            Book book5 = new Book("Potions: 1 Drip 2 Spells", author5, Genre.Potions);
            Book[] OriginalBooks = new Book[] { book1, book2, book3, book4, book5 };
            foreach (Book book in OriginalBooks)
            {
                HogwartsLibrary.Add(book);
            }
        }
        #endregion

        #region ViewAllBooks()
        /// <summary>
        /// Use foreach to loop through all the books in HogwartsLibrary and list out the book title, author, and genre.
        /// </summary>
        public static void ViewAllBooks()
        {
            foreach (Book book in HogwartsLibrary)
            {
                Console.WriteLine($"{book.Title} | Author: {book.Author.FirstName} {book.Author.LastName} | Genre: {book.Genre}");
            }
        }
        #endregion

        #region AddBooks()
        /// <summary>
        /// List out all the genres and take user's input.
        /// Use switch statement to add the book to the corresponding genre category.
        /// Add the book to HogwartsLibrary.
        /// </summary>
        /// <param name="title"></param>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <returns></returns>
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
                    HogwartsLibrary.Add(book);
                    return false;
                case "2":
                    Author author2 = new Author(firstName, lastName);
                    Book book2 = new Book(title, author2, Genre.Transfiguration);
                    HogwartsLibrary.Add(book2);
                    return false;
                case "3":
                    Author author3 = new Author(firstName, lastName);
                    Book book3 = new Book(title, author3, Genre.DarkMagic);
                    HogwartsLibrary.Add(book3);
                    return false;
                case "4":
                    Author author4 = new Author(firstName, lastName);
                    Book book4 = new Book(title, author4, Genre.MuggleStudies);
                    HogwartsLibrary.Add(book4);
                    return false;
                case "5":
                    Author author5 = new Author(firstName, lastName);
                    Book book5 = new Book(title, author5, Genre.Potions);
                    HogwartsLibrary.Add(book5);
                    return false;
                case "6":
                    Author author6 = new Author(firstName, lastName);
                    Book book6 = new Book(title, author6, Genre.AncientRunes);
                    HogwartsLibrary.Add(book6);
                    return false;
                case "7":
                    Author author7 = new Author(firstName, lastName);
                    Book book7 = new Book(title, author7, Genre.HistoryOfMagic);
                    HogwartsLibrary.Add(book7);
                    return false;
                case "8":
                    Author author8 = new Author(firstName, lastName);
                    Book book8 = new Book(title, author8, Genre.Charm);
                    HogwartsLibrary.Add(book8);
                    return false;
                case "9":
                    Author author9 = new Author(firstName, lastName);
                    Book book9 = new Book(title, author9, Genre.CareOfMagicalCreatures);
                    HogwartsLibrary.Add(book9);
                    return false;
                case "10":
                    Author author10 = new Author(firstName, lastName);
                    Book book10 = new Book(title, author10, Genre.Others);
                    HogwartsLibrary.Add(book10);
                    return false;
                default:
                    Console.WriteLine("Please enter a valid selection.");
                    Console.WriteLine("\n");
                    return true;
            }
        }
        #endregion

        #region BorrowBooks()
        /// <summary>
        /// Take user's input on the book title which is to be borrowed.
        /// Loop through HogwartsLibrary to find the book.
        /// Add this book to BookBag and remove it from HogwartsLibrary.
        /// </summary>
        /// <param name="title"></param>
        static void BorrowBooks(string title)
        {
            foreach (Book book in HogwartsLibrary)
            {
                if (book.Title == title)
                {
                    BookBag.Add(book);
                    HogwartsLibrary.Remove(book);
                }
            }
        }
        #endregion

        /// <summary>
        /// Use Dictionary<int, Book> to assign numbers to each book in BookBag.
        /// Take user's selection on which book to return, use TryGetValue method to get the book object information.
        /// Add the book back to HogwartsLibrary and remove it from BookBag.
        /// </summary>
        static string ReturnBooks()
        {
            if (BookBag.Count == 0)
            {
                Console.WriteLine("You don't have any books in your book bag to be returned.");
                Console.ReadLine();
                return "";
            }
            Console.WriteLine("Please select the number of the book that you want to return:");


            Dictionary<int, Book> bookBagList = new Dictionary<int, Book>();
            int bookCount = 1;
            foreach (Book book in BookBag)
            {
                Console.WriteLine($"{bookCount}: {book.Title} | {book.Author.FirstName} {book.Author.LastName} | {book.Genre}");
                bookCount++;
            }
            string bookNumber = Console.ReadLine();
            int.TryParse(bookNumber, out int selection);
            bookBagList.TryGetValue(selection, out Book bookReturned);
            BookBag.Remove(bookReturned);
            HogwartsLibrary.Add(bookReturned);
            return "X";
        }

        #region ViewBookBag()
        /// <summary>
        /// Loop through BookBag and count how many books are in there.
        /// If there is no book in BookBag, let the user know.
        /// If there are books in BookBag, use foreach to print out all the books and return how many books are in BookBag.
        /// </summary>
        /// <returns></returns>
        static int ViewBookBag()
        {
            int totalBookBag = 0;
            foreach (var item in BookBag)
            {
                totalBookBag++;
            }
            if (totalBookBag == 0)
            {
                Console.WriteLine("Your book bag is empty.");
            }
            foreach (var book in BookBag)
            {
                Console.WriteLine($"{book.Title} | Author: {book.Author.FirstName} {book.Author.LastName} | Genre: {book.Genre}");
            }
            return totalBookBag;
        }
        #endregion
    }
}
