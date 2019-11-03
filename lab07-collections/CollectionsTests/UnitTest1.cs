using Xunit;
using System.Collections.Generic;
using lab07_collections;

namespace CollectionsTests
{
    public class UnitTest1
    {
        Library<Book> HogwartsLibrary = new Library<Book>();
        List<Book> BookBag = new List<Book>();

    [Fact]
        public void AddBook()
        {
            Author author1 = new Author("Rolanda", "Hooch");
            Book book1 = new Book("Flying to The Moon", author1, Genre.Motion);
            Assert.Equal(1, HogwartsLibrary.Add(book1));
        }

        [Fact]
        public void RemoveBook()
        {
            Author author1 = new Author("Rolanda", "Hooch");
            Book book1 = new Book("Flying to The Moon", author1, Genre.Motion);
            HogwartsLibrary.Add(book1);
            Assert.True(HogwartsLibrary.Remove(book1));
        }

        [Fact]
        public void RemoveNone()
        {
            Author author1 = new Author("Rolanda", "Hooch");
            Book book1 = new Book("Flying to The Moon", author1, Genre.Motion);
            HogwartsLibrary.Add(book1);
            Author author3 = new Author("Gilderoy", "Lockhart");
            Book book3 = new Book("Defence Against the Dark Arts", author3, Genre.DarkMagic);
            Assert.False(HogwartsLibrary.Remove(book3));
        }

        [Fact]
        public void GetSetBook()
        {
            Author author1 = new Author("Rolanda", "Hooch");
            Book book1 = new Book("Flying to The Moon", author1, Genre.Motion);
            HogwartsLibrary.Add(book1);
            string bookTitle = "";
            foreach (Book book in HogwartsLibrary)
            {
                bookTitle = book.Title;
            }
            Assert.Equal("Flying to The Moon", bookTitle);
        }

        [Fact]
        public void GetSetAuthor()
        {
            Author author1 = new Author("Rolanda", "Hooch");
            Book book1 = new Book("Flying to The Moon", author1, Genre.Motion);
            HogwartsLibrary.Add(book1);
            string bookAuthor = "";
            foreach (Book book in HogwartsLibrary)
            {
                bookAuthor = $"{author1.FirstName} {author1.LastName}";
            }
            Assert.Equal("Rolanda Hooch", bookAuthor);

        }

        [Fact]
        public void CountBooks()
        {
            Author author1 = new Author("Rolanda", "Hooch");
            Book book1 = new Book("Flying to The Moon", author1, Genre.Motion);
            HogwartsLibrary.Add(book1);
            Assert.Equal(1, HogwartsLibrary.Count());
        }
    }
}
