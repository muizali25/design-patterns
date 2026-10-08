Console.WriteLine("================================");
Console.WriteLine("     MEMENTO PATTERN - SOLUTION");
Console.WriteLine("================================\n");

var editor = new TextEditor();
editor.Text = "Hello";
Console.WriteLine($"Current text: {editor.Text}");

var savedState = editor.Save();

editor.Text = "Hello World";
Console.WriteLine($"Current text: {editor.Text}");

editor.Restore(savedState);
Console.WriteLine($"Restored text: {editor.Text}");

Console.WriteLine("\nMemento stores editor state without exposing internals.");

public class EditorMemento
{
    public EditorMemento(string text) => Text = text;
    public string Text { get; }
}

public class TextEditor
{
    public string Text { get; set; } = string.Empty;

    public EditorMemento Save() => new EditorMemento(Text);

    public void Restore(EditorMemento memento) => Text = memento.Text;
}
