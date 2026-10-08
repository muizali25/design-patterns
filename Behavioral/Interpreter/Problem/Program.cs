Console.WriteLine("================================");
Console.WriteLine("  INTERPRETER PATTERN - PROBLEM");
Console.WriteLine("================================\n");

var evaluator = new SimpleExpressionEvaluator();

Console.WriteLine($"Result of '5 + 3' = {evaluator.Evaluate("5 + 3")}");
Console.WriteLine($"Result of '10 - 4' = {evaluator.Evaluate("10 - 4")}");

Console.WriteLine("\nProblem: Parsing and evaluating expressions with string logic is fragile.");
Console.WriteLine("Adding new operations requires more conditional code.");

public class SimpleExpressionEvaluator
{
    public int Evaluate(string expression)
    {
        var parts = expression.Split(' ', StringSplitOptions.RemoveEmptyEntries);
        int left = int.Parse(parts[0]);
        string op = parts[1];
        int right = int.Parse(parts[2]);

        if (op == "+") return left + right;
        if (op == "-") return left - right;

        throw new InvalidOperationException("Unsupported operation.");
    }
}
