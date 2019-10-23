using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace lab07_collections
{
    class Library<Book> : IEnumerable
    {
        private Book[] library = new Book[5];
        private int currentNumber = 0;

        public IEnumerator<Book> GetEnumerator()
        {
            for (int i = 0; i < currentNumber; i++)
            {
                yield return library[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
