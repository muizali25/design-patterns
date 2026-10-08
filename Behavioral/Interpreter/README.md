
# Interpreter Pattern

## Category

Behavioral

## Difficulty

Advanced

## 30-Second Explanation

Define a grammar and interpret sentences in it.

## Intent

Given a language, define a representation for its grammar along with an interpreter.

## Problem

Evaluating simple expressions uses fragile string parsing with if/else.

## Problem Example

5 + 3 and 10 - 4 parsed manually in one method.

## Why Is This a Problem?

Adding operators requires more conditional parsing code.

## Solution

Model expressions as objects that know how to interpret themselves.

## Before vs After

### Before

String splitting and switch/if logic.

### After

Expression tree with Interpret() methods.

## Pattern Structure

```text
AddExpression
   /        \
Number    Number
```

## Participants

Expression, NumberExpression, AddExpression, SubtractExpression

## How It Works

1. Build expression tree.
2. Call Interpret() on root.
3. Leaf nodes return values; composites combine them.

## When Should I Use It?

- Simple, repeated grammars
- Rules map naturally to classes
- Evaluation is the main operation

## When Should I NOT Use It?

- Complex languages (use parser generators)
- Grammar changes frequently

## Real-World Examples

- Simple rule engines
- Query languages
- Mathematical expression evaluators

## How to Remember

"Each rule is a small class."

## Key Learning

- Good for simple grammars
- Easy to extend with new expression types
- Can become complex quickly
- Not for full programming languages

## Run the Example

**Problem project:**

```bash
dotnet run --project Behavioral/Interpreter/Problem
```

**Solution project:**

```bash
dotnet run --project Behavioral/Interpreter/Solution
```

In Visual Studio 2022, set $(System.Collections.Hashtable.Folder.Split('\')[-1]).Problem or $(System.Collections.Hashtable.Folder.Split('\')[-1]).Solution as the startup project and press F5.

## Problem vs Solution Summary

| | Problem | Solution |
|---|---------|----------|
| Design | String parsing with if/else for operators. | Expression objects interpret themselves. |

