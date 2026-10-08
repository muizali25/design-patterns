
# Decorator Pattern

## Category

Structural

## Difficulty

Beginner

## 30-Second Explanation

Wrap an object to add behavior without changing the original class.

## Intent

Attach additional responsibilities to an object dynamically.

## Problem

Every coffee add-on combination requires its own subclass.

## Problem Example

CoffeeWithMilk, CoffeeWithSugar, CoffeeWithMilkAndSugar, etc.

## Why Is This a Problem?

Subclass count grows exponentially with optional features.

## Solution

Wrap the base coffee with decorator objects that add cost and description.

## Before vs After

### Before

Subclass per feature combination.

### After

Stack decorators around a plain coffee at runtime.

## Pattern Structure

```text
SugarDecorator
      |
MilkDecorator
      |
 PlainCoffee
```

## Participants

ICoffee, PlainCoffee, CoffeeDecorator, MilkDecorator, SugarDecorator

## How It Works

1. Decorator implements same interface as component.
2. Decorator wraps another coffee.
3. Calls delegate and adds behavior.

## When Should I Use It?

- Add features dynamically
- Avoid subclass explosion
- Combine behaviors flexibly

## When Should I NOT Use It?

- Behavior combinations are fixed and small
- Order of wrapping does not matter and inheritance is simpler

## Real-World Examples

- Stream wrappers in .NET
- Coffee/add-on pricing
- UI control borders and scrollbars

## How to Remember

"Wrap it to add something."

## Key Learning

- Open for extension, closed for modification
- Flexible runtime composition
- Same interface throughout stack
- Alternative to many subclasses

## Run the Example

**Problem project:**

```bash
dotnet run --project Structural/Decorator/Problem
```

**Solution project:**

```bash
dotnet run --project Structural/Decorator/Solution
```

In Visual Studio 2022, set $(System.Collections.Hashtable.Folder.Split('\')[-1]).Problem or $(System.Collections.Hashtable.Folder.Split('\')[-1]).Solution as the startup project and press F5.

## Problem vs Solution Summary

| | Problem | Solution |
|---|---------|----------|
| Design | Subclass explosion for coffee add-ons. | Decorators wrap coffee to add features dynamically. |

