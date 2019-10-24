using System;
using System.Collections.Generic;
using System.Text;

namespace lab07_collections
{
    public enum Genre
    {
        Motion = 1,
        Transfiguration,
        DarkMagic,
        MuggleStudies,
        Potions
    }

    public class Book
    {
        public string Title { get; set; }

        public Author Author { get; set; }

        public Genre Genre { get; set; }

        public Book(string title, Author author, Genre genre)
        {
            Title = title;
            Author = author;
            Genre = genre;
        }
    }
}
