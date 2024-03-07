using System;

namespace _4task
{
    public class BookCollection
    {
        private Book[] books;
        public delegate bool ComparisonDelegate(Book x, Book y);
        public BookCollection()
        {
        }

        public BookCollection(Book[] books)
        {
            this.books = books;
        }

        public Book[] _books { get { return books; } }

        public void SortCollection(ComparisonDelegate comparison)
        {
            Array.Sort(_books, new Comparison<Book>((x, y) => comparison(x, y) ? 1 : -1));
        }

        public static bool CompareByTitle(Book x, Book y)
        {
            return string.Compare(x._name, y._name) < 0;
        }

        public static bool CompareByAuthor(Book x, Book y)
        {
            return string.Compare(x._author, y._author) < 0;
        }

        public static bool CompareByPublisher(Book x, Book y)
        {
            return string.Compare(x._publisher, y._publisher) < 0;
        }
        public void DisplayCollection()
        {
            foreach (Book book in books)
            {
                Console.WriteLine($"Название: {book._name}, Автор: {book._author}, Издательство: {book._publisher}");
            }
        }

    }
}
