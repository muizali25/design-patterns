
# Builder Pattern

## Category

Creational

## Difficulty

Beginner

## 30-Second Explanation

Build a complex object step-by-step.

## Intent

Separate the construction of a complex object from its representation.

## Problem

Constructors with many parameters become hard to read and maintain.

## Problem Example

A Pizza constructor takes size, toppings, and special instructions in one long call.

## Why Is This a Problem?

Optional combinations are confusing and error-prone.

## Solution

Use a builder with fluent methods to assemble the object step-by-step.

## Before vs After

### Before

One giant constructor with many boolean and string parameters.

### After

Readable chained calls like .SetSize().AddCheese().Build().

## Pattern Structure

```text
PizzaBuilder
  | AddCheese()
  | AddMushrooms()
  | Build()
     v
   Pizza
```

## Participants

PizzaBuilder, Pizza

## How It Works

1. Builder stores intermediate values.
2. Client calls step methods.
3. Build() returns the final product.

## When Should I Use It?

- Many optional configuration steps
- Same construction process, different results
- You want readable object creation

## When Should I NOT Use It?

- Simple objects with few fields
- All parameters are required and obvious

## Real-World Examples

- HTTP request builders
- SQL query builders
- Pizza/meal configurators

## How to Remember

"Step by step, then build."

## Key Learning

- Improves readability
- Separates construction from product
- Supports optional steps easily
- Can validate before Build()

## Run the Example

**Problem project:**

```bash
dotnet run --project Creational/Builder/Problem
```

**Solution project:**

```bash
dotnet run --project Creational/Builder/Solution
```

In Visual Studio 2022, set $(System.Collections.Hashtable.Folder.Split('\')[-1]).Problem or $(System.Collections.Hashtable.Folder.Split('\')[-1]).Solution as the startup project and press F5.

## Problem vs Solution Summary

| | Problem | Solution |
|---|---------|----------|
| Design | Long constructor with many parameters. | Fluent builder assembles the pizza step-by-step. |

