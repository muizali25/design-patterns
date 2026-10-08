Console.WriteLine("================================");
Console.WriteLine("    ITERATOR PATTERN - PROBLEM");
Console.WriteLine("================================\n");

var collection = new BookCollection();
collection.Add(new Book("Design Patterns"));
collection.Add(new Book("Clean Code"));
collection.Add(new Book("Refactoring"));

Console.WriteLine("Client accesses internal list directly:\n");

foreach (var book in collection.Books)
{
    Console.WriteLine($"- {book.Title}");
}

Console.WriteLine("\nProblem: Internal collection structure is exposed to clients.");
Console.WriteLine("Changing storage breaks client code.");

public class Book
{
    public Book(string title) => Title = title;
    public string Title { get; }
}

public class BookCollection
{
    public List<Book> Books { get; } = new();

    public void Add(Book book) => Books.Add(book);
}
