using System;
using System.Collections;
using System.Collections.Generic;

namespace IteratorsAndComparators
{
    public class Book
    {
        public string Title { get; set; }
        public int Year { get; set; }
        public string Author { get; set; }

        public Book(string title, int year, params string[] authors)
        {
            Title = title;
            Year = year;
            Author = string.Join(", ", authors);
        }
    }

    public class Library : IEnumerable<Book>
    {
        private List<Book> books;

        public Library(params Book[] books)
        {
            this.books = new List<Book>(books);
        }

        public IEnumerator<Book> GetEnumerator()
        {
            return new LibraryIterator(books);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        private class LibraryIterator : IEnumerator<Book>
        {
            private List<Book> books;
            private int currentIndex;

            public LibraryIterator(List<Book> books)
            {
                this.books = books;
                Reset();
            }

            public Book Current => books[currentIndex];

            object IEnumerator.Current => Current;

            public void Dispose()
            {
                // Nothing to dispose
            }

            public bool MoveNext()
            {
                return ++currentIndex < books.Count;
            }

            public void Reset()
            {
                currentIndex = -1;
            }
        }
    }

    public static class StartUp
    {
        public static void Main()
        {
            Book bookOne = new Book("Animal Farm", 2003, "George Orwell");
            Book bookTwo = new Book("The Documents in the Case", 2002, "Dorothy Sayers", "Robert Eustace");
            Book bookThree = new Book("The Documents in the Case", 1930);

            Library libraryTwo = new Library(bookOne, bookTwo, bookThree);

            foreach (var book in libraryTwo)
            {
                Console.WriteLine(book.Title);
            }
        }
    }
}