
# Visitor Pattern

## Category

Behavioral

## Difficulty

Advanced

## 30-Second Explanation

Add new operations without changing the element classes.

## Intent

Represent an operation to be performed on elements of an object structure.

## Problem

Export logic uses type checks for each shape in client code.

## Problem Example

Adding a new operation requires modifying client if/else blocks.

## Why Is This a Problem?

Operations and object structure become tightly coupled.

## Solution

Shapes accept visitors that implement operation-specific logic.

## Before vs After

### Before

Client switches on shape types for each operation.

### After

Visitor classes implement operations; shapes call Accept().

## Pattern Structure

```text
IShape -> Accept(visitor)
              |
        AreaExportVisitor
```

## Participants

IShape, Circle, Rectangle, IShapeVisitor, AreaExportVisitor

## How It Works

1. Client creates visitor.
2. Each shape Accept()s visitor.
3. Visitor performs type-specific operation.

## When Should I Use It?

- Stable class hierarchy, changing operations
- Many unrelated operations on same structure
- Double dispatch needed

## When Should I NOT Use It?

- Element hierarchy changes often
- Only one simple operation exists

## Real-World Examples

- AST compilers
- Document export (PDF, XML)
- Tax calculation on item types

## How to Remember

"Bring the operation to the objects."

## Key Learning

- Separates operations from elements
- Easy to add new visitors
- Hard to add new element types
- Uses double dispatch

## Run the Example

**Problem project:**

```bash
dotnet run --project Behavioral/Visitor/Problem
```

**Solution project:**

```bash
dotnet run --project Behavioral/Visitor/Solution
```

In Visual Studio 2022, set $(System.Collections.Hashtable.Folder.Split('\')[-1]).Problem or $(System.Collections.Hashtable.Folder.Split('\')[-1]).Solution as the startup project and press F5.

## Problem vs Solution Summary

| | Problem | Solution |
|---|---------|----------|
| Design | Client if/else for each shape operation. | Visitor adds operations without changing shapes. |

