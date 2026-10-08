Console.WriteLine("================================");
Console.WriteLine("    ITERATOR PATTERN - SOLUTION");
Console.WriteLine("================================\n");

var collection = new BookCollection();
collection.Add(new Book("Design Patterns"));
collection.Add(new Book("Clean Code"));
collection.Add(new Book("Refactoring"));

Console.WriteLine("Client iterates without knowing internal storage:\n");

foreach (var book in collection)
{
    Console.WriteLine($"- {book.Title}");
}

Console.WriteLine("\nThe collection exposes a standard way to traverse items.");

public class Book
{
    public Book(string title) => Title = title;
    public string Title { get; }
}

public class BookCollection : IEnumerable<Book>
{
    private readonly List<Book> _books = new();

    public void Add(Book book) => _books.Add(book);

    public IEnumerator<Book> GetEnumerator() => _books.GetEnumerator();

    System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() => GetEnumerator();
}
