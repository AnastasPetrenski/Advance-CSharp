using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace IteratorsAndComparators
{
    public class Library : IEnumerable<Book>
    {
        private List<Book> books { get; set; }

        public Library(params Book[] books)
        {
            this.books = new List<Book>(books);
        }

        public IEnumerator<Book> GetEnumerator()
        {
            //return books.GetEnumerator();
            return new LibraryIterator(books);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        private class LibraryIterator : IEnumerator<Book>
        {
            private int index = -1;

            private List<Book> books;

            public LibraryIterator(List<Book> books)
            {
                this.books = books;
            }

            public Book Current => this.books[index];

            object IEnumerator.Current => this.books[index];

            public void Dispose()
            {
            }

            public bool MoveNext()
            {
                return ++index < this.books.Count;
            }

            public void Reset()
            {
                this.index = -1;
            }

        }
    }


    
}
