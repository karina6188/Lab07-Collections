using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace lab07_collections
{
    class Library<T> : IEnumerable
    {
        /// <summary>
        /// Create a generic type array that takes 10 items.
        /// Assign current index to be zero
        /// </summary>
        private T[] library = new T[10];
        private int currentIndex = 0;

        /// <summary>
        /// When everytime a book is added into the library array, current index increments by 1.
        /// When the library array has 10 items already and more items are to be added, resize
        /// the array size to have 5 more available spaces. Use current index to assign the new
        /// book to be at the index position inside library array. 
        /// </summary>
        /// <param name="book"></param>
        public void Add(T book)
        {
            if(currentIndex == library.Length)
            {
                Array.Resize(ref library, library.Length + 5 );
            }
            library[currentIndex] = book;
            currentIndex++;
        }

        public void Remove(T book)
        {

        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < currentIndex; i++)
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
