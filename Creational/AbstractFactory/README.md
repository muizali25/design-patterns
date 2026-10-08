
# Abstract Factory Pattern

## Category

Creational

## Difficulty

Intermediate

## 30-Second Explanation

Create families of related objects that must work together.

## Intent

Provide an interface for creating families of related objects without specifying concrete classes.

## Problem

Client can accidentally mix incompatible UI components from different themes.

## Problem Example

A dark button is paired with a light checkbox.

## Why Is This a Problem?

There is no guarantee that created components belong to the same family.

## Solution

Use theme-specific factories that create matching button and checkbox products.

## Before vs After

### Before

Client creates individual components directly and may mix themes.

### After

Client asks a factory for a complete compatible UI family.

## Pattern Structure

```text
IGUIFactory
   /         \
DarkTheme   LightTheme
   |            |
Button+Box   Button+Box
```

## Participants

IGUIFactory, IButton, ICheckbox, DarkThemeFactory, LightThemeFactory

## How It Works

1. Abstract factory declares creation methods for each product.
2. Concrete factories return matching products.
3. Client uses one factory at a time.

## When Should I Use It?

- Products must be used together
- Multiple product families exist
- You want to enforce consistency

## When Should I NOT Use It?

- Only one product type is needed (use Factory Method)
- Families rarely change

## Real-World Examples

- UI themes
- Cross-platform widget kits
- Database provider families (connection + command)

## How to Remember

"Pick one factory, get a matching set."

## Key Learning

- Creates product families
- Prevents incompatible combinations
- More complex than Factory Method
- Client depends on abstractions only

## Run the Example

**Problem project:**

```bash
dotnet run --project Creational/AbstractFactory/Problem
```

**Solution project:**

```bash
dotnet run --project Creational/AbstractFactory/Solution
```

In Visual Studio 2022, set $(System.Collections.Hashtable.Folder.Split('\')[-1]).Problem or $(System.Collections.Hashtable.Folder.Split('\')[-1]).Solution as the startup project and press F5.

## Problem vs Solution Summary

| | Problem | Solution |
|---|---------|----------|
| Design | Mixed dark button and light checkbox. | Theme factories create compatible component sets. |

