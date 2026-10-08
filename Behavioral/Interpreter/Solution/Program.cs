Console.WriteLine("================================");
Console.WriteLine("  INTERPRETER PATTERN - SOLUTION");
Console.WriteLine("================================\n");

Expression five = new NumberExpression(5);
Expression three = new NumberExpression(3);

Expression add = new AddExpression(five, three);
Expression subtract = new SubtractExpression(new NumberExpression(10), new NumberExpression(4));

Console.WriteLine($"Result of 5 + 3 = {add.Interpret()}");
Console.WriteLine($"Result of 10 - 4 = {subtract.Interpret()}");

Console.WriteLine("\nEach expression type knows how to interpret itself.");

public interface Expression
{
    int Interpret();
}

public class NumberExpression : Expression
{
    private readonly int _value;

    public NumberExpression(int value) => _value = value;

    public int Interpret() => _value;
}

public class AddExpression : Expression
{
    private readonly Expression _left;
    private readonly Expression _right;

    public AddExpression(Expression left, Expression right)
    {
        _left = left;
        _right = right;
    }

    public int Interpret() => _left.Interpret() + _right.Interpret();
}

public class SubtractExpression : Expression
{
    private readonly Expression _left;
    private readonly Expression _right;

    public SubtractExpression(Expression left, Expression right)
    {
        _left = left;
        _right = right;
    }

    public int Interpret() => _left.Interpret() - _right.Interpret();
}
