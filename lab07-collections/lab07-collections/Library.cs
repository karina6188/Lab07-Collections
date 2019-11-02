﻿using System;
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
            // is the item in the collection?
            // find it
            // manipulate array to remove the item
            // eventually send to resize
        }

        /// <summary>
        /// It does the action one at a time, that means the for loop is
        /// getting something back one at a time. If you have a return
        /// statement in this for loop, that means there will be values
        /// being returned every tume instead of just one final return
        /// at the end.
        /// </summary>
        /// <returns></returns>
        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < currentIndex; i++)
            {
                yield return library[i];
            }
        }

        /// <summary>
        /// This are legacy codes that come from C# version 1.0.
        /// However this is conflicting with the later version, so these
        /// are included here to prevent something from breaking.
        /// </summary>
        /// <returns></returns>
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
