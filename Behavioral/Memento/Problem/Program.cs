Console.WriteLine("================================");
Console.WriteLine("     MEMENTO PATTERN - PROBLEM");
Console.WriteLine("================================\n");

var editor = new TextEditor();
editor.Text = "Hello";
Console.WriteLine($"Current text: {editor.Text}");

editor.Text = "Hello World";
Console.WriteLine($"Current text: {editor.Text}");

Console.WriteLine("\nProblem: There is no safe way to undo changes.");
Console.WriteLine("Saving state would require exposing internal details.");

public class TextEditor
{
    public string Text { get; set; } = string.Empty;
}
