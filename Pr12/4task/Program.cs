using System;

/*
Написать делегат, с помощью которого реализуется
сортировка книг. Книга представляет собой класс с полями Название, Автор,
Издательство и конструктором. Создать класс, являющийся контейнером для
множества книг (массив книг). В этом классе предусмотреть метод
сортировки книг. Критерий сортировки определяется экземпляром делегата,
который передается методу в качестве параметра. Каждый экземпляр
делегата должен сравнивать книги по какому-то одному полю: названию,
автору, издательству. 
*/
namespace _4task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book[] books = new Book[]
            {
            new Book("Жизнь 0", "Попов", "Санкт"),
            new Book("Программирование за", "Мельников", "Петр2"),
            new Book("С#", "Кузнецов", "Жизненно")
            };

            BookCollection bookCollection = new BookCollection(books);

            Console.WriteLine("Сортировка по названию:");
            bookCollection.SortCollection(BookCollection.CompareByTitle);
            bookCollection.DisplayCollection();

            Console.WriteLine("\nСортировка по автору:");
            bookCollection.SortCollection(BookCollection.CompareByAuthor);
            bookCollection.DisplayCollection();

            Console.WriteLine("\nСортировка по издательству:");
            bookCollection.SortCollection(BookCollection.CompareByPublisher);
            bookCollection.DisplayCollection();
            Console.ReadKey();

        }
    }
}
